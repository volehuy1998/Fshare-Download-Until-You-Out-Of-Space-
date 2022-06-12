using Consoler.Fshare_Ngoại_Lệ_Riêng;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consoler.Fshare_Nhật_Ký
{
    public abstract class Fshare_Nhật_Ký_Sơ_Cấp : Fshare_Nhật_Ký_Mơ_Hồ
    {
        public virtual string Chuẩn_Hóa_Thông_Điệp(string thông_điệp)
        {
            return Lấy_Ngày_Giờ_Hiện_Tại() + $" [{Environment.UserName}] ~ " + thông_điệp;
        }
        
        public virtual string Lấy_Ngày_Giờ_Hiện_Tại()
        {
            return $"{DateTime.Now.ToString("MM-dd-yyyy HH:mm:ss")}";
        }

        public virtual void Ghi_Cảnh_Báo(string thông_điệp)
        {
            throw new Fshare_Ngoại_Lệ_Nhật_Ký_Thứ_Cấp();
        }

        public virtual void Ghi_Dấu_Vết(string thông_điệp)
        {
            throw new Fshare_Ngoại_Lệ_Nhật_Ký_Thứ_Cấp();
        }

        public virtual void Ghi_Lỗi(Exception thông_điệp_ngoại_lệ)
        {
            throw new Fshare_Ngoại_Lệ_Nhật_Ký_Thứ_Cấp();
        }

        public virtual void Ghi_Thành_Công(string thông_điệp)
        {
            throw new Fshare_Ngoại_Lệ_Nhật_Ký_Thứ_Cấp();
        }

    }
}
