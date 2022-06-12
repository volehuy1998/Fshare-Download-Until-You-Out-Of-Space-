using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Consoler.Fshare_Nhật_Ký
{
    class Fshare_Nhật_Ký_Sơ_Cấp_Tệp_Tin : Fshare_Nhật_Ký_Sơ_Cấp
    {
        private readonly string tên_tệp_tin_nhật_ký = string.Empty;
        public Fshare_Nhật_Ký_Sơ_Cấp_Tệp_Tin()
        {
            string invalid = new string(Path.GetInvalidFileNameChars()) + new string(Path.GetInvalidPathChars());
            Regex regex = new Regex(string.Format("[{0}]", Regex.Escape(invalid)));
            tên_tệp_tin_nhật_ký = $"{Lấy_Ngày_Giờ_Hiện_Tại()}.log";
            var thư_mục_nhật_ký = Directory.CreateDirectory("nhật_ký");
            tên_tệp_tin_nhật_ký = Path.Combine(thư_mục_nhật_ký.FullName, regex.Replace(tên_tệp_tin_nhật_ký, "_"));
        }

        public override void Ghi_Lỗi(Exception thông_điệp)
        {
            File.AppendAllText(tên_tệp_tin_nhật_ký, Chuẩn_Hóa_Thông_Điệp(thông_điệp.ToString()));
        }

        public override void Ghi_Thành_Công(string thông_điệp)
        {
            File.AppendAllText(tên_tệp_tin_nhật_ký, Chuẩn_Hóa_Thông_Điệp(thông_điệp));
        }

        public override void Ghi_Cảnh_Báo(string thông_điệp)
        {
            File.AppendAllText(tên_tệp_tin_nhật_ký, Chuẩn_Hóa_Thông_Điệp(thông_điệp));
        }

        public override void Ghi_Dấu_Vết(string thông_điệp)
        {
            File.AppendAllText(tên_tệp_tin_nhật_ký, Chuẩn_Hóa_Thông_Điệp(thông_điệp));
        }
    }
}
