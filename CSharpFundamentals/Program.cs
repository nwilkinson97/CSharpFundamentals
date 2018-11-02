using CSLib;

namespace CSharpFundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            IntroductionToClasses();
            ClassConstructorPartI();
            ClassConstructorsPartII();

            
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

        private static void ClassConstructorPartI()
        {
            // Using the Class Constructor with the signature of type ID and the Object Initilizer to set the Field Name
            var customer = new Customer(1) { Name = "Thing One" };
            System.Console.WriteLine("Searching for customer id:  {0} with the name of {1}", customer.Id, customer.Name);

            //  Using the Class constructor looking for the ID of type int
            var customer2 = new Customer(2);
            //  Then set the value of that customer2 Name Field
            customer2.Name = "Thing King";
            System.Console.WriteLine("Searching for customer id:  {0} with the name of {1}", customer2.Id, customer2.Name);

            //  Using the Class Constructor to set both the ID and Name
            var customer3 = new Customer(3, "Thing Super");
            System.Console.WriteLine("Searching for customer id:  {0} with the name of {1}", customer3.Id, customer3.Name);

            // Using Object Initializer to set both the Id and Name fields
            var customer4 = new Customer()
            {
                Id = 4
                , Name = "Chocolate Thunda"
            };
            System.Console.WriteLine("Searching for customer id:  {0} with the name of {1}", customer4.Id, customer4.Name);
        }

        private static void ClassConstructorsPartII()
        {
            //  This section here is used to show two things.
            //  When the class dos not initizliae the List of Orders object an error is generated.
            //     Note:  Do not try and fix by initializing the List here.  This should be done
            //             where the work is required.
            var customer = new Customer(1, "Ben");
            customer.Orders.Add(new Orders());
        }
        #endregion
    }
}
