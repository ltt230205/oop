
using System.Collections.Generic;
using System;

public class GroceryBill
{

    private Employee NhanVien;
    protected List<Item> MatHang;

    public GroceryBill(Employee nhanVien)
    {
        NhanVien = nhanVien;
        MatHang = new List<Item>();
    }

    public void Them(Item item)
    {
        MatHang.Add(item);
    }

    public double TongTien()
    {
        double tong = 0;
        foreach (var item in MatHang)
        {
            tong += item.Gia;
        }
        return tong;
    }

    public void InHoaDon()
    {
        Console.WriteLine("Nhân viên: " + NhanVien.Ten);
        foreach (var item in MatHang)
        {
            Console.WriteLine(item.Ten + ": $" + item.Gia);
        }
        Console.WriteLine("Tổng cộng: $" + TongTien());
    }
}
