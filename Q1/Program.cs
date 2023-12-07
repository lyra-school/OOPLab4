/* Name: Lyra Karsaj
 * Date: 11/10/23
 * Desc: Car 
 */
namespace Q1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car("Ford", "Focus", 0, 1.6);
            Car car2 = new Car("Opel", "Astra", 0, 1.2);

            // Q1
            PrintCarInfo(car1);
            PrintCarInfo(car2);

            // Q2
            car2.DisplayCarInfo();
            for(int i = 0; i < 10; i++)
            {
                car1.Accelerate();
            }
            Console.WriteLine(car1.ToString());
        }

        // Q1
        public static void PrintCarInfo(Car car)
        {
            Console.WriteLine("The " + car.Make + " " + car.Model + ", engine size " + car.EngineSize + "l is currently travelling at " + car.CurrentSpeed + "km/h");
        }
    }
}