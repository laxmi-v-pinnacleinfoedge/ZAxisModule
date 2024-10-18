using System.Diagnostics;
using ZAxisModule.Data;
using ZAxisModule.ModelVM;
using ZAxisModule.Repositories.abstractrepositories;

namespace ZAxisModule.Repositories.Concrete
{
    public class Login : ILogin, IDisposable
    {
        ApplicationDBContext _db;
        private readonly Extension _session;

        public Login(ApplicationDBContext db, Extension session)
        {
            _db = db;
            _session = session;
        }
        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    _db.Dispose();
                }
            }
            this.disposed = true;
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        public bool IsValid(LoginVM loginVM)
        {
            SessionValues sessionValues = new SessionValues();
            bool result = false;
            var userMaster = _db.UserMasterNw.Where(um => um.EMPNO == loginVM.EmployeeNumber.ToString()
            && um.USERPASS == loginVM.Password);

            var employees = _db.Employee.ToList();
            var zbaMasters = _db.ZbaMaster.ToList();

            var joined = from um in userMaster.ToList()
                         join em in employees on Convert.ToDecimal(um.EMPNO) equals em.EMPNO
                         join zm in zbaMasters on em.ZBAID equals zm.ZBAID
                         select new
                         {
                             UserMaster = um,
                             Employee = em,
                             ZbaMaster = zm
                         };


            foreach (var item in joined)
            {
                _session.SetSessionValue(sessionValues.SessionID, Guid.NewGuid().ToString());
                _session.SetSessionValue(sessionValues.UserID, item.UserMaster.USERID);
                _session.SetSessionValue(sessionValues.UserID, item.UserMaster.USERID);
                _session.SetSessionValue(sessionValues.UserName, item.UserMaster.USERNAME);
                _session.SetSessionValue(sessionValues.UserLogin, item.UserMaster.USERNAME);
                _session.SetSessionValue(sessionValues.GroupCode, item.UserMaster.GROUPCODE);
                _session.SetSessionValue(sessionValues.MasterEmpno, item.UserMaster.EMPNO);
                _session.SetSessionValue(sessionValues.MasterName, item.UserMaster.USERNAME);
            }


            foreach (var item in employees)
            {
                _session.SetSessionValue(sessionValues.Zbaid, item.ZBAID.ToString());
            }
            return result;
        }

    }
}
