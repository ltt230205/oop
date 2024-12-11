
public class BillLine
{
    public Item MatHang { get; private set; }
    public int SoLuong { get; private set; }

    public BillLine(Item matHang, int soLuong)
    {
        MatHang = matHang;
        SoLuong = soLuong;
    }

    public void CapNhatSoLuong(int soLuong)
    {
        SoLuong = soLuong;
    }

    public double TinhTongTien()
    {
        return MatHang.Gia * SoLuong;
    }
}

