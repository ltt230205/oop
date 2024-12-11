
using System.Collections.Generic;
using System;

public class GroceryBillWithLines
{
    private Employee NhanVien;
    private List<BillLine> CacDongHoaDon;

    public GroceryBillWithLines(Employee nhanVien)
    {
        NhanVien = nhanVien;
        CacDongHoaDon = new List<BillLine>();
    }

    public void Them(BillLine dongHoaDon)
    {
        CacDongHoaDon.Add(dongHoaDon);
    }

    public double TongTien()
    {
        double tong = 0;
        foreach (var dongHoaDon in CacDongHoaDon)
        {
            tong += dongHoaDon.TinhTongTien();
        }
        return tong;
    }

    public void InHoaDon()
    {
        Console.WriteLine("Nhân viên: " + NhanVien.Ten);
        foreach (var dongHoaDon in CacDongHoaDon)
        {
            Console.WriteLine(dongHoaDon.MatHang.Ten + " x" + dongHoaDon.SoLuong + ": $" + dongHoaDon.TinhTongTien());
        }
        Console.WriteLine("Tổng cộng: $" + TongTien());
    }
}