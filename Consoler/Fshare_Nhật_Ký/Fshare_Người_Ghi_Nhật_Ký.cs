using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consoler.Fshare_Nhật_Ký
{
    class Fshare_Người_Ghi_Nhật_Ký
    {
        private HashSet<Fshare_Nhật_Ký_Mơ_Hồ> fshare_Các_Cách_Thức_Ghi_Nhật_Ký = new HashSet<Fshare_Nhật_Ký_Mơ_Hồ>();

        public Fshare_Người_Ghi_Nhật_Ký(params Fshare_Nhật_Ký_Mơ_Hồ[] fshare_Các_Cách_Thức_Ghi_Nhật_Ký)
        {
            this.fshare_Các_Cách_Thức_Ghi_Nhật_Ký.Union(fshare_Các_Cách_Thức_Ghi_Nhật_Ký);
        }

        public void Add<Thể_Loại_Fshare_Nhật_Ký_Mơ_Hồ>()
        {
            fshare_Các_Cách_Thức_Ghi_Nhật_Ký.Add(Activator.CreateInstance(typeof(Thể_Loại_Fshare_Nhật_Ký_Mơ_Hồ)) as Fshare_Nhật_Ký_Mơ_Hồ);
        }

        public void Ghi_Lỗi(Exception thông_điệp_ngoại_lệ)
        {
            foreach (var fshare_Nhật_Ký_Mơ_Hồ in fshare_Các_Cách_Thức_Ghi_Nhật_Ký)
            {
                fshare_Nhật_Ký_Mơ_Hồ.Ghi_Lỗi(thông_điệp_ngoại_lệ);
            }
        }

        public void Ghi_Thành_Công(string thông_điệp)
        {
            foreach (var fshare_Nhật_Ký_Mơ_Hồ in fshare_Các_Cách_Thức_Ghi_Nhật_Ký)
            {
                fshare_Nhật_Ký_Mơ_Hồ.Ghi_Thành_Công(thông_điệp);
            }
        }

        public void Ghi_Cảnh_Báo(string thông_điệp)
        {
            foreach (var fshare_Nhật_Ký_Mơ_Hồ in fshare_Các_Cách_Thức_Ghi_Nhật_Ký)
            {
                fshare_Nhật_Ký_Mơ_Hồ.Ghi_Cảnh_Báo(thông_điệp);
            }
        }

        public void Ghi_Dấu_Vết(string thông_điệp)
        {
            foreach (var fshare_Nhật_Ký_Mơ_Hồ in fshare_Các_Cách_Thức_Ghi_Nhật_Ký)
            {
                fshare_Nhật_Ký_Mơ_Hồ.Ghi_Dấu_Vết(thông_điệp);
            }
        }
    }
}
