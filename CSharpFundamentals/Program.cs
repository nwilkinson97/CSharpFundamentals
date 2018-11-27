using CSLib;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;

namespace CSharpFundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            IntroductionToClasses();
            ClassConstructorPartI();
            ClassConstructorsPartII();
            MethodsInClasses();
            UsingParamsModifier();
            IntTryParseMethod_OutParam();
            FieldsWithReadonlyModifier();
            FieldsEncapsulatedWithPublicGetterAndSetterMethods();
            UsingDictionaryClass();
            UsingInheritance();
            UsingCompositionToLinkClasses();
            ConstructorsAndInheritanceBaseClass();
            DowncastingShapeTextToShape();
            BoxingAndUnboxing();

        }







        #region Section 1 -- Introduction Object Oriented Programming (OOP)
        private static void IntroductionToClasses()
        {
            //  New instance of the person class for Thing 1
            var person = new Person(new DateTime(1997, 04, 18))
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
            customer.Order.Add(new Orders());
        }

        private static void MethodsInClasses()
        {
            try
            {
                //  Set the initial location
                var point = new Point(15, 30);
                // Display Initial Location
                Console.WriteLine("You are now located at ({0}:{1})", point.X, point.Y);

                //  Move the cursor to a new location
                point.Move(null);
                Console.WriteLine("You are now located at ({0}:{1})", point.X, point.Y);

                //  Move the cursor to a new lcoation
                point.Move(new Point(19, 31));
                Console.WriteLine("You are now located at ({0}:{1})", point.X, point.Y);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
        }

        private static void UsingParamsModifier()
        {
            // Create a new instance of the Calculator Class
            var calculator = new Calculator();

            //  Add by pasing a new integer array
            Console.WriteLine(new int[] { 1, 2 });
            Console.WriteLine(new int[] { 1, 2, 3 });
            Console.WriteLine(new int[] { 1, 2, 3, 4 });
            Console.WriteLine(new int[] { 1, 2, 3, 4, 5 });

            // or alternatively you could just pass the values as parameters
            Console.WriteLine(calculator.Add(1, 2));
            Console.WriteLine(calculator.Add(1, 2));
            Console.WriteLine(calculator.Add(1, 2, 3));
            Console.WriteLine(calculator.Add(1, 2, 3, 4));
            Console.WriteLine(calculator.Add(1, 2, 3, 4, 5));
        }

        private static void IntTryParseMethod_OutParam()
        {
            //var number = int.Parse("abc");

            //  Try Parse Result is False
            var result = int.TryParse("abc", out int n1);
            DisplayConversionMessage(result, n1);

            //  Try Parse Result is True
            result = int.TryParse("123", out int n2);
            DisplayConversionMessage(result, n2);
        }

        private static void DisplayConversionMessage(bool result, int number)
        {
            //  If result is True) 
            if (result)
                Console.WriteLine("Conversion Success -- {0}", number);
            else //  Else result is False
                Console.WriteLine("Conversion Failure");
        }

        private static void FieldsWithReadonlyModifier()
        {
            // Create new instance of the customer class
            var customer = new Customer(1);

            //  Add 2 Orders to the Customer 1
            customer.Order.Add(new Orders());
            customer.Order.Add(new Orders());

            // Promote the Customer
            customer.Promote();

            // Output the Count of Orders
            Console.WriteLine(customer.Order.Count);
        }

        /// <summary>
        /// In the future it can be better to use properties.  I will show you this in the 
        /// next section as we progress.
        /// </summary>
        private static void FieldsEncapsulatedWithPublicGetterAndSetterMethods()
        {
            // Create an instance of person
            var person = new Person(new DateTime(1997, 04, 18));

            // Get the persons birthdate
            Console.WriteLine(person.BirthDate);

            Console.WriteLine(person.Age);
        }

        private static void UsingDictionaryClass()
        {
            // Create an instance of the HttpCookie calass in CSLib
            var cookie = new HttpCookie();
            // Store a value in the dictionary 
            cookie["name"] = "Thing One";
            //  Retrieve a value from the dictionary
            Console.WriteLine(cookie["name"]);
        }

        private static void UsingInheritance()
        {
            //  Create a New Intance of the Text Class
            //  and use its object initializer to set the 
            //  Height and Width from its base class 
            //  Presentation Object.  Through Inheritance
            //  this is possilbe.
            var text = new Text
            {
                Width = 100
                ,
                Height = 100
            };

            // Call the Copy function from the base class.  
            // Inheritance makes it easy to use the behavior
            // from one class and extend its capabilities.
            text.Copy();
        }


        private static void UsingCompositionToLinkClasses()
        {
            // Create an Instance of DbMigator
            var dbMigrator = new DBMigrator(new Logger());

            // Create an installce of the Logger Class
            var logger = new Logger();
            // Create new instance of the Installer Class
            // and pass the logger class created above.
            var installer = new Installer(logger);

            // Perform Migration
            dbMigrator.Migrate();

            // Perform Installation
            installer.Install();
        }

        private static void ConstructorsAndInheritanceBaseClass()
        {
            //  create new instance of the Car class and pass the VIN Number
            var car = new Car("vin1234567890");
        }

        private static void DowncastingShapeTextToShape()
        {
            //  Create new instance of ShapeText class
            ShapeText shapeText = new ShapeText();
            // Create new Shape Object derrived from ShapeText
            Shape shape = shapeText;

            // Belong in Shape.cs however accessible due to downcasting
            shapeText.Height = 200;
            shapeText.Width = 100;

            //  Display information
            Console.WriteLine("Shape Height {0} and Width {1}", shapeText.Height, shapeText.Width);
        }

        private static void BoxingAndUnboxing()
        {
            // Boxing occurs for primitive data types
            // A string passed is a reference type
            var listOne = new ArrayList();
            listOne.Add(1);  // boxing occurs
            listOne.Add("Hello"); // no boxing
            listOne.Add(DateTime.Today); // boxing occurs

            // No Boxing or Unboxing used here
            // List is of a single type and defined
            var listTwo = new List<int>();
            listTwo.Add(1);
            listTwo.Add(3);
            listTwo.Add(7);

            // No Boxing or Unboxing used here
            // List is of a single type and defined
            var listThree = new List<string>();
            listThree.Add("Thing 1");
            listThree.Add("Thing 2");
            listThree.Add("King Thing");
        }
        #endregion
    }
}
