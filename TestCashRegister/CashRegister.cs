namespace TestCashRegister
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

        public CashRegister()
        {
        }

        public void AddItem(double value)
        {
            _total += value;
            _itemCount++;
        }
    }
}