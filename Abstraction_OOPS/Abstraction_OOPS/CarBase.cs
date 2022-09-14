namespace AbstractionDemo
{
    public class CarBase
    {
        public static void Main(String[] args)
        {
            Car CarObject = new Car();
            string CarName = CarObject.CarName;
            string CarColur = CarObject.CarColur;
            CarObject.Brakes();
            CarObject.Gear();
            CarObject.Steering();
        }
    }
}