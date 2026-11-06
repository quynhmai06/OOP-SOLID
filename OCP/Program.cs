using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP
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
    public class ZaloPayment : Payment
    {
        public override void Pay(decimal amount)
        {
            Console.WriteLine("Thanh toán bằng ZaloPay: " + amount + " VNĐ");
        }
    }
    public class PaymentService
    {
        public void ProcessPayment(Payment payment, decimal amount)
        {
            payment.Pay(amount);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            PaymentService service = new PaymentService();
            Payment bank = new BankPayment();
            Payment momo = new MomoPayment();
            Payment zalo = new ZaloPayment();
            service.ProcessPayment(bank, 200000);
            service.ProcessPayment(momo, 500000);
            service.ProcessPayment(zalo, 300000);
            Console.ReadKey();
        }
    }
}
