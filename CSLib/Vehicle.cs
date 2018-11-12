namespace CSLib
{
    public class Vehicle
    {
        private readonly string _registrationNumber;

        //public Vehicle()
        //{
        //    System.Console.WriteLine("Vehicle is being initialized.");
        //}

        public Vehicle(string registrationNumber)
        {
            this._registrationNumber = registrationNumber;
            System.Console.WriteLine("The vehicle with the registration number {0} is being initialized", registrationNumber);
        }
    }
}
