namespace AbstractionDemo
{
    public class Car
    {
        private string _CarName = "Honda City";
        private string _CarColur = "Black";

        public string CarName
        {
            set
            {
                _CarName = value;
            }
            get
            {
                return _CarName;
            }
        }
        public string CarColur
        {
            set
            {
                _CarColur = value;
            }
            get
            {
                return _CarColur;
            }
        }

        public void Steering()
        {
            Console.WriteLine("Streering of the Car");
        }

        public void Brakes()
        {
            Console.WriteLine("Brakes of the Car");
        }

        public void Gear()
        {
            Console.WriteLine("Gear of the Car");
        }

        private void CarEngine()
        {
            Console.WriteLine("Engine of the Car");
        }

        private void DeisalEngine()
        {
            Console.WriteLine("DeisalEngine of the Car");
        }

        private void Silencer()
        {
            Console.WriteLine("Silencer of the Car");
        }
    }
}