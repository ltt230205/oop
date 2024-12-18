using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW4
{
    internal class QuanLyNganHang
    {
        // Lớp GiaoDich
        public class GiaoDich
        {
            public DateTime Ngay { get; set; }
            public string Loai { get; set; } // Nạp tiền hoặc Rút tiền
            public double SoTien { get; set; }

            public GiaoDich(DateTime ngay, string loai, double soTien)
            {
                Ngay = ngay;
                Loai = loai;
                SoTien = soTien;
            }
        }
        // Lớp TaiKhoanNganHang
        public class TaiKhoanNganHang
        {
            public string SoTaiKhoan { get; set; }
            public string TenKhachHang { get; set; }
            public string CMND { get; set; }
            public double SoDu { get; private set; }
            public double LaiSuat { get; set; } // tính theo %
            private List<GiaoDich> GiaoDichs;

            public TaiKhoanNganHang(string soTaiKhoan, string tenKhachHang, string cmnd, double soDuBanDau, double laiSuat)
            {
                SoTaiKhoan = soTaiKhoan;
                TenKhachHang = tenKhachHang;
                CMND = cmnd;
                SoDu = soDuBanDau;
                LaiSuat = laiSuat;
                GiaoDichs = new List<GiaoDich>();
            }

            public void NapTien(double soTien, DateTime ngay)
            {
                SoDu += soTien;
                GiaoDichs.Add(new GiaoDich(ngay, "Nạp tiền", soTien));
            }
            public void RutTien(double soTien, DateTime ngay)
            {
                if (soTien > SoDu)
                    throw new InvalidOperationException("Số dư không đủ");
                SoDu -= soTien;
                GiaoDichs.Add(new GiaoDich(ngay, "Rút tiền", soTien));
            }

            public void TinhLaiSuat()
            {
                double lai = SoDu * (LaiSuat / 100);
                SoDu += lai;
            }

            public void InBaoCao()
            {
                Console.WriteLine($"Số tài khoản: {SoTaiKhoan}");
                Console.WriteLine($"Tên khách hàng: {TenKhachHang}");
                Console.WriteLine($"Số dư: {SoDu:F2} €");
                Console.WriteLine("Các giao dịch:");
                foreach (var giaoDich in GiaoDichs)
                {
                    Console.WriteLine($"- {giaoDich.Ngay.ToShortDateString()} {giaoDich.Loai} {giaoDich.SoTien:F2} €");
                }
            }
        }
        // Lớp NganHang
        public class NganHang
        {
            private List<TaiKhoanNganHang> TaiKhoans;

            public NganHang()
            {
                TaiKhoans = new List<TaiKhoanNganHang>();
            }

            public void MoTaiKhoan(string soTaiKhoan, string tenKhachHang, string cmnd, double soDuBanDau, double laiSuat)
            {
                TaiKhoans.Add(new TaiKhoanNganHang(soTaiKhoan, tenKhachHang, cmnd, soDuBanDau, laiSuat));
            }

            public TaiKhoanNganHang LayTaiKhoan(string soTaiKhoan)
            {
                foreach (var taiKhoan in TaiKhoans)
                {
                    if (taiKhoan.SoTaiKhoan == soTaiKhoan)
                        return taiKhoan;
                }
                throw new InvalidOperationException("Không tìm thấy tài khoản");
            }
            public void ApDungLaiSuatChoTatCaTaiKhoan()
            {
                foreach (var taiKhoan in TaiKhoans)
                {
                    taiKhoan.TinhLaiSuat();
                }
            }

            public void InTatCaBaoCao()
            {
                foreach (var taiKhoan in TaiKhoans)
                {
                    taiKhoan.InBaoCao();
                    Console.WriteLine("----------------------------");
                }
            }
        }
    }
}
