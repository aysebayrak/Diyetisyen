using Business.Constants;
using Core.Utilities.Interceptors;
using Core.Utilities.IOC;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Castle.DynamicProxy;

using Microsoft.Extensions.DependencyInjection;
using Core.Extensions;

namespace Business.BusinessAspects.Autofac
{
    //yetkilendirme if suysa 
    //JWT için
    public class SecuredOperation : MethodInterception
    {
        private string[] _roles;
        private IHttpContextAccessor _httpContextAccessor;
        //her iştek yapana bir   tane  HTTP oluşturan 
        public SecuredOperation(string roles)//rolleri ver
        {
            _roles = roles.Split(',');//verdiklerimi array yaptı 
            _httpContextAccessor = ServiceTool.ServiceProvider.GetService<IHttpContextAccessor>();
            //SERVİCE TOOL =İLE DEPENDENCY LERİ YAKALAYABİLMEK  İÇİN
            //İNJEKSIN ALT YAPIMIZI AYNEN OKUYABİLNENEİZE SAĞLAYACAK 
        }

        protected override void OnBefore(IInvocation invocation)//on before bu metodun önünde çalıştır
        {
            var roleClaims = _httpContextAccessor.HttpContext.User.ClaimRoles();
            foreach (var role in _roles)//yetkis varsa bitir
            {
                if (roleClaims.Contains(role))
                {
                    return;
                }
            }
            throw new Exception(Messages.AuthorizationDenied);
        }
    }
}
