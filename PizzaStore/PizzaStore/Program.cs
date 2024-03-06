using static System.Formats.Asn1.AsnWriter;

namespace PizzaStore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Store.Start(); // Initiates the pizza store application.
            Console.WriteLine("Made by Amir Jawad.");
            Console.ReadKey();
        }
    }
}
