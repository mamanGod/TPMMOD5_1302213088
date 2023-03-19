// See https://aka.ms/new-console-template for more information
public class HaloGeneric
{

    public void Menyapa<X>(X user)
    {
        Console.WriteLine("Halo user " + user.ToString());
    }
}

class Program
{
    static void Main(string[] args)
    {
        HaloGeneric halo = new HaloGeneric();
        string nama = "Rahman";
        halo.Menyapa(nama);
    }
}