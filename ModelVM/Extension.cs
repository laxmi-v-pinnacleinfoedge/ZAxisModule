using Microsoft.AspNetCore.Http;
using System.Text.Json;

namespace ZAxisModule.ModelVM
{
    public  class Extension
    {
        private readonly IHttpContextAccessor _httpContextAccessor;

        public Extension(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }

        public void SetSessionValue(string key, string value)
        {
            var session = _httpContextAccessor.HttpContext.Session;
            session.SetString(key, value);
        }
        public string GetSessionValue(string key)
        {
            var session = _httpContextAccessor.HttpContext.Session;
            return session.GetString(key);
        }
    }
}
