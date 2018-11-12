namespace CSLib
{
    public class Car : Vehicle
    {
        public Car(string registrationNumber) : base(registrationNumber)
        {
            // Display message showing that the object is being initialized,
            //  Note that we use the base keyword to access to pass the reigstrationNumber to the class constructor of the Vehicle Class
            System.Console.WriteLine("Car is being initialized with the registration number of {0}", registrationNumber);
        }
    }
}
