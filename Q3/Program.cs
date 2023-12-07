/* Name: Lyra Karsaj
 * Date: 11/10/23
 * Desc: Bank Account
 */
namespace Q3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            BankAccount acc1 = new BankAccount(123456789, "A. J.", 1000);
            BankAccount acc2 = new BankAccount(4326347, "B. R.", 2000);

            double amt1 = 1000;
            double amt2 = 500;

            Console.WriteLine(acc1.ToString());
            Console.WriteLine(acc2.ToString());
            acc1.Deposit(amt1);
            Console.WriteLine($"Adding {amt1:c} to account 1");
            Console.WriteLine(acc1.ToString());
            acc2.Withdraw(amt2);
            Console.WriteLine($"Withdrawing {amt2:c} from account 2");
            Console.WriteLine(acc2.ToString());
        }
    }
}