using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    public abstract class Payment
    {
        public abstract void Pay(decimal amount);
    }
    public class BankPayment : Payment
    {
        public override void Pay(decimal amount)
        {
            Console.WriteLine("Thanh toán bằng ngân hàng: " + amount + " VNĐ");
        }
    }
    public class MomoPayment : Payment
    {
        public override void Pay(decimal amount)
        {
            Console.WriteLine("Thanh toán bằng Momo: " + amount + " VNĐ");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Payment payment = new BankPayment();
            Payment payment1 = new MomoPayment();
            payment.Pay(200000);
            payment1.Pay(500000);
            Console.ReadKey();
        }
    }
}
