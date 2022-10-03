namespace FileInputOutput
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Input Output Program");
            Addressbook.ReadFromStreamReader();
            Addressbook.WriteUsingStreamReader();
        }
    }
}