using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consoler.Fshare_Nhật_Ký
{
    class Fshare_Nhật_Ký_Sơ_Cấp_Console : Fshare_Nhật_Ký_Sơ_Cấp
    {
        public override void Ghi_Lỗi(Exception thông_điệp)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(Chuẩn_Hóa_Thông_Điệp(thông_điệp.Message));
            Console.ResetColor();
        }

        public override void Ghi_Thành_Công(string thông_điệp)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(Chuẩn_Hóa_Thông_Điệp(thông_điệp));
            Console.ResetColor();
        }

        public override void Ghi_Cảnh_Báo(string thông_điệp)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(Chuẩn_Hóa_Thông_Điệp(thông_điệp));
            Console.ResetColor();
        }

        public override void Ghi_Dấu_Vết(string thông_điệp)
        {
            Console.WriteLine(Chuẩn_Hóa_Thông_Điệp(thông_điệp));
        }
    }
}
