# OOP-SOLID
Ví dụ về 4 tính chất của OOP và chữ "O" trong SOLID
1. 4 tính chất của OOP
- Tính đóng gói (Encapsulation): bảo vệ dữ liệu và kiểm soát truy cập.
VD: 1 tài khoản ngân hàng có phương thức XemSoDu(), nhưng mình không thể tự ý thay đổi số dư mà phải dựa vào phương thức NapTien() để thay đổi số dư.
- Tính kế thừa (Inheritance): class cha chia sẻ dữ liệu và phương thức cho class con mà không cần phải định nghĩa lại.
VD: Tạo một lớp Animal có phương thức Eat(), tạo thêm một lớp Dog có phương thức Bark() và kế thừa từ lớp Animal phương thức Eat().
- Tính trừu tượng (Abstraction): thực hiện các chức năng cần thiết và ẩn đi chi tiết triển khai bên trong
VD: Tạo một lớp Payment có phương thức Pay() và tạo 2 lớp con BankPayment và MomoPayment kế thừa và ghi đè lên phương thức của lớp Payment. Ở hàm main, mình sẽ tạo đối tượng nào mình muốn thanh toán.
- Tính đa hình (Polymorphism): các object ở các class khác nhau có thể hiểu chung 1 thông điệp theo cách khác nhau.
VD: Tạo lớp Animal với phương thức ảo Speak() và tạo 2 lớp con Dog và Cat kế thừa từ class Animal và ghi đè phương thức Speak() lên class Animal. 
2. Chữ "O" trong SOLID
- Open/Closed Principle (OCP): mở rộng thêm chức năng mới mà không cần sửa code cũ.
VD: Tạo class Payment có phương thức Pay(), 2 class con BankPayment và MomoPayment được kế thừa phương thức Pay() từ class Payment. Sau đó, tạo thêm class PaymentService để làm việc với bất kì lớp con nào của Payment mà không phụ thuộc trực tiếp vào BankPayment hay MomoPayment. Khi muốn thêm phương thức thanh toán ZaloPayment thì chỉ cần tạo thêm class ZaloPayment và ở hàm main chỉ cần gọi phương thức thanh toán Zalo thì sẽ được.

