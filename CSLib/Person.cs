using System;

namespace CSLib
{
    public class Person
    {
        /// <summary>
        /// This is a field!
        /// The purpose of this field is to store the users name
        /// Later on I will cover properties which are more efficient.
        /// </summary>
        public string Name;

        /// <summary>
        /// THe User Name for Login Purposes
        /// </summary>
        public string UserName { get; set; }
        
        /// <summary>
        /// Birth Date that can only be set within the class constructor
        /// </summary>
        public DateTime BirthDate { get; private set; }

        /// <summary>
        /// Class Constructor that expects an argument to be passsed for the 
        /// BirthDate (Auto-Implemented) Property
        /// </summary>
        /// <param name="birthDate"></param>
        public Person(DateTime birthDate)
        {
            BirthDate = birthDate;
        }

        /// <summary>
        /// This is a Method used to intruduce to people.
        /// </summary>
        /// <param name="to"></param>
        public void Introduce(string to)
        {
            // Introductions are in order
            System.Console.WriteLine("Hello {0}, I am {1}!", to, Name);
        }

        /// <summary>
        /// This Function allows us to parse a string and return
        /// an instance of the Person Class.  By using the static
        /// keyword this function is available from the Class and
        /// not an instance of the class.  An instance is considered
        /// to be an object and you cannot call static functions from.
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static Person Parse(string str)
        {
            //  Lets instantiate a new object of the type Person
            var person = new Person(new DateTime(1997, 04, 18))
            {
                Name = str
            };

            // Return the person object
            return person;
        }

        /// <summary>
        /// Get the age of the person using business logic and the BirthDate
        /// </summary>
        public int Age
        {
            get
            {
                //  Subtract Todays Date (Present) - BirthDate (Past)
                var timeSpan = DateTime.Today - BirthDate;
                //  Divide the timeSpan by 365 days (year)
                var years = timeSpan.Days / 365;

                //  return years
                return years;
            }
        }
    }
}
