using Consoler.Fshare_Api;
using Consoler.Fshare_Ngoại_Lệ_Riêng;
using Newtonsoft.Json;
using System;
using System.Net;
using System.Net.Http;
using System.Text;

namespace Consoler
{
    public class Fshare_Người_Giao_Tiếp_Http
    {
        private HttpClient Tạo_Người_Giao_Tiếp_Http()
        {
            return new HttpClient()
            {
                BaseAddress = new Uri(Fshare_Chuỗi_Cứng.FshareApi_Địa_Chỉ_Máy_Chủ)
            };
        }

        public Fshare_Chứng_Chỉ Đăng_Nhập()
        {
            using (var người_giao_tiếp_http = Tạo_Người_Giao_Tiếp_Http())
            {
                người_giao_tiếp_http.DefaultRequestHeaders.UserAgent.ParseAdd(Fshare_Chuỗi_Cứng.FshareApi_AppName);
                HttpRequestMessage thông_điệp_yêu_cầu = new HttpRequestMessage(HttpMethod.Post, Fshare_Chuỗi_Cứng.FshareApi_Đăng_Nhập);
                thông_điệp_yêu_cầu.Content = new StringContent(FshareApi_Người_Tạo_Nội_Dung_Body_Đăng_Nhập.Tạo(
                        Fshare_Chuỗi_Cứng.FshareApi_User_Hoặc_Email,
                        Fshare_Chuỗi_Cứng.FshareApi_Mật_Khẩu,
                        Fshare_Chuỗi_Cứng.FshareApi_AppKey),
                    Encoding.UTF8,
                    "application/json");
                var thông_điệp_phản_hồi = người_giao_tiếp_http.SendAsync(thông_điệp_yêu_cầu).Result;
                var kết_quả_đăng_nhập_dạng_chuỗi = thông_điệp_phản_hồi.Content.ReadAsStringAsync().Result;
                var kết_quả_đăng_nhập = JsonConvert.DeserializeObject<FshareApi_Kết_Quả_Đăng_Nhập>(kết_quả_đăng_nhập_dạng_chuỗi);
                if (kết_quả_đăng_nhập.Mã_Http_Trả_về == HttpStatusCode.OK)
                {
                    return new Fshare_Chứng_Chỉ()
                    {
                        Fshare_Token = kết_quả_đăng_nhập.Token,
                        Fshare_SessionId = kết_quả_đăng_nhập.SessionId
                    };
                }
                throw new FshareApi_Ngoại_Lệ_Đăng_Nhập(kết_quả_đăng_nhập_dạng_chuỗi);
            }
        }

        public void Đăng_Xuất(Fshare_Chứng_Chỉ fshare_Chứng_Chỉ)
        {
            using (var người_giao_tiếp_http = Tạo_Người_Giao_Tiếp_Http())
            {
                người_giao_tiếp_http.DefaultRequestHeaders.Add("Cookie", $"session_id={fshare_Chứng_Chỉ.Fshare_SessionId}");
                var thông_điệp_phản_hồi = người_giao_tiếp_http.GetAsync(Fshare_Chuỗi_Cứng.FshareApi_Đăng_Xuất).Result;
                var kết_quả_đăng_nhập_dạng_chuỗi = thông_điệp_phản_hồi.Content.ReadAsStringAsync().Result;
                var kết_quả_đăng_xuất = JsonConvert.DeserializeObject<FshareApi_Kết_Quả_Đăng_Xuất>(kết_quả_đăng_nhập_dạng_chuỗi);
            }
        }
    }
}
