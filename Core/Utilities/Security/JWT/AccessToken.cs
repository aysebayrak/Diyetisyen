using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Security.JWT
{
  public  class AccessToken
    {
        //kişiye verdiğim yetkilendirme token bilgisi
        public string Token { get; set; }//jeton 
        public DateTime Expiration { get; set; }//süresi ne zaman bitecek  
    }
}
