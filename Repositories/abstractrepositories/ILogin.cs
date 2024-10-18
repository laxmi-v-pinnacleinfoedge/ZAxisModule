using ZAxisModule.ModelVM;

namespace ZAxisModule.Repositories.abstractrepositories
{
    public interface ILogin
    {
        bool IsValid(LoginVM loginVM);
    }
}
