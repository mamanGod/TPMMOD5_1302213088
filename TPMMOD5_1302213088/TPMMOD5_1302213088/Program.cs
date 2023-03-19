// See https://aka.ms/new-console-template for more information
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

        DataGeneric<string> data = new DataGeneric<string>("1302213088");
        data.PrintData();
    }
}