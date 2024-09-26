namespace CarClass;

class Program
{
    static void Main(string[] args)
    {
        Car car = new Car("Hyundai", "i30n", 2019, 0.0);
        car.Drive(1000);
        car.DisplayMileage();
        car.Drive(1000);
        car.DisplayMileage();
    }
}