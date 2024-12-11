using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
            Employee nhanVien = new Employee("Nguyễn Văn A");

            // Demo DiscountBill
            DiscountBill hoaDonChietKhau = new DiscountBill(nhanVien, true);
            hoaDonChietKhau.Them(new Item("Kẹo", 1.35, 0.25));
            hoaDonChietKhau.Them(new Item("Sữa", 2.50, 0.0));
            hoaDonChietKhau.Them(new Item("Bánh mì", 3.00, 0.5));
            hoaDonChietKhau.InHoaDon();
            Console.WriteLine("Tổng tiền sau chiết khấu: $" + hoaDonChietKhau.TongTien());
            Console.WriteLine("Số lượng chiết khấu: " + hoaDonChietKhau.LaySoLuongChietKhau());
            Console.WriteLine("Tổng chiết khấu: $" + hoaDonChietKhau.LayTongChietKhau());
            Console.WriteLine("Phần trăm chiết khấu: " + hoaDonChietKhau.LayPhanTramChietKhau() + "%");

            // Demo GroceryBillWithLines
            GroceryBillWithLines hoaDonDong = new GroceryBillWithLines(nhanVien);
            hoaDonDong.Them(new BillLine(new Item("Kẹo", 1.35, 0.25), 2));
            hoaDonDong.Them(new BillLine(new Item("Sữa", 2.50, 0.0), 1));
            hoaDonDong.Them(new BillLine(new Item("Bánh mì", 3.00, 0.5), 3));
            hoaDonDong.InHoaDon();
        }
    }
}
