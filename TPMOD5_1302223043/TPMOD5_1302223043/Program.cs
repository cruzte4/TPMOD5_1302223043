// See https://aka.ms/new-console-template for more information
public class DataGeneric<T>
{
    private T data;
    public DataGeneric(T data)
    {
        this.data = data;
    }

    public void PrintData()
    {
        Console.WriteLine("Data yang tersimpan adalah: " + data);
    }

}

class Program
{
    static void Main(string[] args)
    {
        DataGeneric<string> dataString = new DataGeneric<string>("132223043");
        dataString.PrintData();

        DataGeneric<int> dataInt = new DataGeneric<int>(132223043);
        dataInt.PrintData();
    }
}
