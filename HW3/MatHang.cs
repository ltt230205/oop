
public class Item
{
    public string Ten { get; private set; }
    public double Gia { get; private set; }
    public double ChietKhau { get; private set; }

    public Item(string ten, double gia, double chietKhau)
    {
        Ten = ten;
        Gia = gia;
        ChietKhau = chietKhau;
    }
}
