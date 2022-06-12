using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consoler.Fshare_Api
{
    class LoginBody
    {
        [JsonProperty(PropertyName = "user_email")]
        public string UserMail { get; set; }

        [JsonProperty(PropertyName = "password")]
        public string Password { get; set; }

        [JsonProperty(PropertyName = "app_key")]
        public string AppKey { get; set; }

        public LoginBody(string mail, string pwd, string appKey)
        {
            UserMail = mail;
            Password = pwd;
            AppKey = appKey;
        }
    }

    public class FshareApi_Người_Tạo_Nội_Dung_Body_Đăng_Nhập
    {
        public static string Tạo(string mail, string pwd, string appKey)
        {
            return JsonConvert.SerializeObject(new LoginBody(mail, pwd, appKey));
        }
    }
}
