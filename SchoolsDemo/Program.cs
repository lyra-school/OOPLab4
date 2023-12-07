/* Name: Lyra Karsaj
 * Date: 11/10/23
 * Desc: Sorting schools
 */
namespace SchoolsDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<School> schools = new List<School>();
            Console.Write("Enter minimum enrollment count to display: ");
            int minLimit = Int32.Parse(Console.ReadLine());
            for(int i = 0; i < 5; i++)
            {
                Console.Write("Enter school name: ");
                string name = Console.ReadLine();
                Console.Write("Enter enrollment: ");
                int enrollment = Int32.Parse(Console.ReadLine());
                if( enrollment >= minLimit )
                {
                    schools.Add(new School(name, enrollment));
                }
            }
            schools.Sort();
            foreach(School school in schools)
            {
                Console.WriteLine(school.Name + " has " + school.Enrollment + " students.");
            }
        }
    }
}