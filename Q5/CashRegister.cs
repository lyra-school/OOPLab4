namespace Q5
{
    public class CashRegister
    {
        private double _total;
        private int _itemCount;
        public double Total
        {
            get { return _total; }
        }
        public int ItemCount
        {
            get { return _itemCount; }
        }

        public static double overallTotal = 0;
        public static int overallItemCount = 0;

        public CashRegister()
        {
        }

        public void AddItem(double value)
        {
            _total += value;
            _itemCount++;
            overallTotal += value;
            overallItemCount++;
        }
    }
}