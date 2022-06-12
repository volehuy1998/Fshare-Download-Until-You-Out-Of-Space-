using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Consoler.Fshare_Api
{
    public class FshareApi_Kết_Quả
    {
        [JsonProperty(PropertyName = "code")]
        public HttpStatusCode Mã_Http_Trả_về { get; set; }
        [JsonProperty(PropertyName = "msg")]
        public string Thông_Điệp { get; set; }
    }
}
