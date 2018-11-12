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
            //  Here we dont have a class constructor that is empty.
            //  Because we commented the code above out.
            //  Since we did this we have code that only has a construcotr that will accept a string value
            //  In this construcotr we set the Field for registration number to the value passed and begin to initialize the object
            this._registrationNumber = registrationNumber;
            System.Console.WriteLine("The vehicle with the registration number {0} is being initialized", registrationNumber);
        }
    }
}
