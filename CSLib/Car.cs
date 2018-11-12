namespace CSLib
{
    public class Car : Vehicle
    {
        public Car(string registrationNumber) : base(registrationNumber)
        {
            System.Console.WriteLine("Car is being initialized with the registration number of {0}", registrationNumber);
        }
    }
}
