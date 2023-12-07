/* Name: Lyra Karsaj
 * Date: 11/10/23
 * Desc: Cash register addition
 */
namespace TestCashRegister
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CashRegister CR1 = new CashRegister();
            CashRegister CR2 = new CashRegister();

            double[] values = { 2.7, 3.45, 5.97, 12.52, 1.43, 15.57, 5.15 };

            CR1.AddItem(values[0]);
            Console.WriteLine($"Adding an item worth {values[0]} to {nameof(CR1)}");
            CR1.AddItem(values[1]);
            Console.WriteLine($"Adding an item worth {values[1]} to {nameof(CR1)}");
            CR1.AddItem(values[2]);
            Console.WriteLine($"Adding an item worth {values[2]} to {nameof(CR1)}");
            CR2.AddItem(values[3]);
            Console.WriteLine($"Adding an item worth {values[3]} to {nameof(CR2)}");
            CR2.AddItem(values[4]);
            Console.WriteLine($"Adding an item worth {values[4]} to {nameof(CR2)}");
            CR2.AddItem(values[5]);
            Console.WriteLine($"Adding an item worth {values[5]} to {nameof(CR2)}");
            CR2.AddItem(values[6]);
            Console.WriteLine($"Adding an item worth {values[6]} to {nameof(CR2)}");
            Console.WriteLine($"Cash Register {nameof(CR1)} Total: {CR1.Total}\nCash Register {nameof(CR1)} Number of Items: {CR1.ItemCount}");
            Console.WriteLine($"Cash Register {nameof(CR2)} Total: {CR2.Total}\nCash Register {nameof(CR2)} Number of Items: {CR2.ItemCount}");
        }
    }
}