using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static HW4.QuanLyNganHang;

namespace HW4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
            NganHang nganHang = new NganHang();

            // Mở tài khoản
            nganHang.MoTaiKhoan("001", "Alice", "901", 100, 5);
            nganHang.MoTaiKhoan("002", "Bob", "902", 50, 5);
            nganHang.MoTaiKhoan("003", "Alice", "901", 200, 10);
            nganHang.MoTaiKhoan("004", "Eve", "903", 200, 10);

            // Giao dịch
            nganHang.LayTaiKhoan("001").NapTien(100, new DateTime(2005, 7, 15));
            nganHang.LayTaiKhoan("001").NapTien(100, new DateTime(2005, 7, 31));
            nganHang.LayTaiKhoan("002").NapTien(150, new DateTime(2005, 7, 1));
            nganHang.LayTaiKhoan("002").NapTien(150, new DateTime(2005, 7, 15));
            nganHang.LayTaiKhoan("003").NapTien(200, new DateTime(2005, 7, 5));
            nganHang.LayTaiKhoan("004").NapTien(250, new DateTime(2005, 7, 31));

            nganHang.LayTaiKhoan("001").RutTien(10, new DateTime(2005, 7, 10));
            nganHang.LayTaiKhoan("002").RutTien(20, new DateTime(2005, 7, 15));
            nganHang.LayTaiKhoan("003").RutTien(30, new DateTime(2005, 7, 31));
            nganHang.LayTaiKhoan("004").RutTien(40, new DateTime(2005, 7, 31));

            // Áp dụng lãi suất
            nganHang.ApDungLaiSuatChoTatCaTaiKhoan();

            // In báo cáo
            nganHang.InTatCaBaoCao();

            Console.ReadKey();
        }
    }
}

