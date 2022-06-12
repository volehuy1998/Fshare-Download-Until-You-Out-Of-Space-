using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consoler.Fshare_Ngoại_Lệ_Riêng
{
    public class FshareApi_Ngoại_Lệ_Đăng_Nhập : Exception
    {
        public FshareApi_Ngoại_Lệ_Đăng_Nhập(string thông_điệp_ngoại_lệ) : base(thông_điệp_ngoại_lệ)
        {
        }
    }
}
