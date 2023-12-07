namespace SchoolsDemo
{
    public class School : IComparable<School>
    {
        private string _name;
        private int _enrollment;

        public string Name
        {
            get { return _name; }
        }

        public int Enrollment
        {
            get { return _enrollment; }
        }

        public School(string name, int enrollment)
        {
            _name = name;
            _enrollment = enrollment;
        }

        public int CompareTo(School other)
        {
            if(other == null) return 1;

            return _enrollment.CompareTo(other._enrollment);
        }

        public static bool operator > (School a, School b)
        {
            return a.CompareTo(b) > 0;
        }
        public static bool operator < (School a, School b)
        {
            return a.CompareTo(b) < 0;
        }
        public static bool operator >= (School a, School b)
        {
            return a.CompareTo(b) >= 0;
        }
        public static bool operator <= (School a, School b)
        {
            return a.CompareTo(b) <= 0;
        }
    }
}