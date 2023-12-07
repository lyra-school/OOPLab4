namespace Q1
{
    public class Car
    {
        private string _make;
        private string _model;
        private double _currentSpeed;
        private double _engineSize;

        public string Make
        {
            get { return _make; }
            set { _make = value; }
        }

        public string Model
        {
            get { return _model; }
            set { _model = value; }
        }

        public double CurrentSpeed
        {
            get { return _currentSpeed; }
            set { _currentSpeed = value; }
        }

        public double EngineSize
        {
            get { return _engineSize; }
            set { _engineSize = value; }
        }

        public Car(string make, string model, double currentSpeed, double engineSize)
        {
            Make = make;
            Model = model;
            CurrentSpeed = currentSpeed;
            EngineSize = engineSize;
        }

        public void DisplayCarInfo()
        {
            Console.WriteLine($"Car Make: {Make}");
            Console.WriteLine($"Car Model: {Model}");
            Console.WriteLine($"Current Speed: {CurrentSpeed}");
            Console.WriteLine($"Engine Size: {EngineSize}");
        }
        public override string ToString()
        {
            return $"Car Make: {Make}\nCar Model: {Model}\nCurrent Speed: {CurrentSpeed}\nEngine Size: {EngineSize}";
        }
        public void Accelerate()
        {
            CurrentSpeed += 10;
            Console.WriteLine($"Current Speed is {CurrentSpeed}");
        }
    }
}