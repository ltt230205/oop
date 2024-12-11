
public class DiscountBill : GroceryBill {
    private bool KhachHangUuTien;
    private int SoLuongChietKhau;
    private double TongChietKhau;

    public DiscountBill(Employee nhanVien, bool khachHangUuTien) : base(nhanVien) {
        KhachHangUuTien = khachHangUuTien;
    }

    public new double TongTien() {
        double tong = 0;
        SoLuongChietKhau = 0;
        TongChietKhau = 0;
        foreach (var item in base.MatHang) {
            if (KhachHangUuTien && item.ChietKhau > 0) {
                SoLuongChietKhau++;
                TongChietKhau += item.ChietKhau;
                tong += item.Gia - item.ChietKhau;
            } else {
                tong += item.Gia;
            }
        }
        return tong;
    }

    public int LaySoLuongChietKhau() {
        return SoLuongChietKhau;
    }

    public double LayTongChietKhau() {
        return TongChietKhau;
    }

    public double LayPhanTramChietKhau() {
        double tongGoc = base.TongTien();
        return tongGoc > 0 ? (TongChietKhau / tongGoc) * 100 : 0;
    }
}