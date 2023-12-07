/* Name: Lyra Karsaj
 * Date: 11/10/23
 * Desc: Lunch menu
 */
namespace LunchDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Lunch lunch1 = new Lunch("hamburger","fries","cola");
            Lunch lunch2 = new Lunch("hot dog","chips","lemonade");
            Lunch lunch3 = new Lunch("pizza", "salad", "iced tea");

            LunchDisplay(lunch1,lunch2,lunch3);
        }

        public static void LunchDisplay(params Lunch[] lunches)
        {
            Console.WriteLine($"{"Entree",-30}{"Side Dish",-30}{"Drink",-30}");
            foreach( Lunch lunch in lunches )
            {
                Console.WriteLine($"{lunch.Entree,-30}{lunch.SideDish,-30}{lunch.Drink,-30}");
            }
        }
    }
}