using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consoler.Fshare_Ngoại_Lệ_Riêng
{
    public class Fshare_Ngoại_Lệ_Nhật_Ký_Thứ_Cấp : Exception
    {
        public Fshare_Ngoại_Lệ_Nhật_Ký_Thứ_Cấp() : base("Chưa triển khai cách thức ghi nhật ký hoặc thiếu từ `override`") {}
    }
}
