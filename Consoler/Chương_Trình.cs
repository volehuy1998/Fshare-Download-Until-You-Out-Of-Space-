using Consoler.Fshare_Api;
using Consoler.Fshare_Nhật_Ký;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Text;

namespace Consoler
{
    class Chương_Trình
    {
        private static Fshare_Người_Giao_Tiếp_Http Fshare_Người_Giao_Tiếp_Http = null;
        private static Fshare_Chứng_Chỉ Fshare_Chứng_Chỉ = null;
        private static Fshare_Người_Ghi_Nhật_Ký Fshare_Người_Ghi_Nhật_Ký = new Fshare_Người_Ghi_Nhật_Ký();
        static void Main(string[] args)
        {
            Cài_Đặt();
            try
            {
                Fshare_Chứng_Chỉ = Fshare_Người_Giao_Tiếp_Http.Đăng_Nhập();
            }
            catch (Exception ngoại_lệ)
            {
                Fshare_Người_Ghi_Nhật_Ký.Ghi_Lỗi(ngoại_lệ);
            }
            finally
            {
                if (Fshare_Chứng_Chỉ != null)
                {
                    Fshare_Người_Giao_Tiếp_Http.Đăng_Xuất(Fshare_Chứng_Chỉ);
                }
            }
        }

        private static void Cài_Đặt()
        {
            Console.OutputEncoding = Encoding.UTF8;

            Fshare_Người_Giao_Tiếp_Http = new Fshare_Người_Giao_Tiếp_Http();
            Fshare_Người_Ghi_Nhật_Ký = new Fshare_Người_Ghi_Nhật_Ký();

            Fshare_Người_Ghi_Nhật_Ký.Add<Fshare_Nhật_Ký_Sơ_Cấp_Console>();
            Fshare_Người_Ghi_Nhật_Ký.Add<Fshare_Nhật_Ký_Sơ_Cấp_Tệp_Tin>();
        }
    }
}
