// See https://aka.ms/new-console-template for more information

public class HaloGeneric
{

    public void Menyapa<X>(X user)
    {
        Console.WriteLine("Halo user " + user.ToString());
    }
}

public class DataGeneric<X>
{
    private X data;

    public DataGeneric(X data)
    {
        this.data = data;
    }

    public void PrintData()
    {
        Console.WriteLine("Data yang tersimpan adalah: " + data.ToString());
    }
}

class Program
{
        static void Main(string[] args)
        {

            HaloGeneric halo = new HaloGeneric();
            string nama = "Rahman";
            halo.Menyapa(nama);
        

        DataGeneric<string> data = new DataGeneric<string>("1302213088");
        data.PrintData();
    }
}