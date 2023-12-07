namespace LunchDemo
{
    public class Lunch
    {
        private string _entree;
        private string _sideDish;
        private string _drink;

        public string Entree
        {
            get { return _entree; }
        }

        public string SideDish
        {
            get { return _sideDish; }
        }

        public string Drink
        {
            get { return _drink; }
        }

        public Lunch(string entree, string sideDish, string drink)
        {
            _entree = entree;
            _sideDish = sideDish;
            _drink = drink;
        }
    }
}