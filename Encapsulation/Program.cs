using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Security.Cryptography.X509Certificates;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    
    public class TaiKhoanNganHang
    {
        private decimal SoDu = 1000000;
        public void NapTien(decimal amount)
        {
            if (amount > 0)
            {
                SoDu += amount;
            }    
        }
        public decimal XemSoDu()
        {
            return SoDu;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            TaiKhoanNganHang taiKhoan = new TaiKhoanNganHang();
            taiKhoan.NapTien(500000);
            Console.WriteLine("Số dư tài khoản là: " + taiKhoan.XemSoDu());
            Console.ReadKey();
        }
    }
}
