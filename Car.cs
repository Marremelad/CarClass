namespace CarClass;

public class Car
{
    private string _make;
    private string _model;
    private int _year;
    private double _mileage;

    public Car(string make, string model, int year, double mileage)
    {
        this._make = make;
        this._model = model;
        this._year = year;
        this._mileage = mileage;
    }

    public double Mileage
    {
        get => _mileage;
        set
        {
            if (_mileage >= 2000)
            {
                throw new ArgumentException("Your car has passed the recommended mileage.");
            }

            _mileage = value;
        }
    }

    public void Drive(double kilometers)
    {
        Mileage += (kilometers / 10);
    }

    public void DisplayMileage()
    {
        Console.WriteLine(_mileage);
    }

    public void DisplayCar()
    {
        Console.WriteLine($"Make: {_make}\nModel: {_model}\nYear: {_year}\nMileage: {_mileage}");
    }
}