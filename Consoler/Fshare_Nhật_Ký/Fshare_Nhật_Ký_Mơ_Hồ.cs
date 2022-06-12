using System;

namespace Consoler.Fshare_Nhật_Ký
{
    public interface Fshare_Nhật_Ký_Mơ_Hồ
    {
        public void Ghi_Lỗi(Exception thông_điệp_ngoại_lệ);
        public void Ghi_Thành_Công(string thông_điệp);
        public void Ghi_Cảnh_Báo(string thông_điệp);
        public void Ghi_Dấu_Vết(string thông_điệp);
    }
}
