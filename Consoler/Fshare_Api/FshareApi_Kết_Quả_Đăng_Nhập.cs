using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consoler.Fshare_Api
{
    class FshareApi_Kết_Quả_Đăng_Nhập : FshareApi_Kết_Quả
    {
        [JsonProperty(PropertyName = "token")]
        public string Token { get; set; }
        [JsonProperty(PropertyName = "session_id")]
        public string SessionId { get; set; }
    }
}
