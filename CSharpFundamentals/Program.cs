using CSLib;

namespace CSharpFundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            IntroductionToClasses();

            var customer = new Customer(1) { Name = "Thing One" };
            System.Console.WriteLine("Searching for customer id:  {0} with the name of {1}", customer.Id, customer.Name);

            var customer2 = new Customer(2);
            customer2.Name = "Thing King";
            System.Console.WriteLine("Searching for customer id:  {0} with the name of {1}", customer2.Id, customer2.Name);

            var customer3 = new Customer(3, "Thing Super");
            System.Console.WriteLine("Searching for customer id:  {0} with the name of {1}", customer3.Id, customer3.Name);
        }

        #region Section 1 -- Introduction to Classes
        private static void IntroductionToClasses()
        {
            //  New instance of the person class for Thing 1
            var person = new Person
            {
                Name = "Thing One"
            };
            //  Introduce Thing 1 to Thing 2
            person.Introduce("Thing Two");

            // Use Static Parse Method to create a new instance of
            // the person class.
            var person2 = Person.Parse("King Thing");
            //  Introduce King Thing to Super Thing
            person2.Introduce("Super Thing");
        }
        #endregion
    }
}
