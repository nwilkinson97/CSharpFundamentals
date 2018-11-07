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

        private DateTime _birthDate;

        /// <summary>
        /// This is a Method used to intruduce to people.
        /// </summary>
        /// <param name="to"></param>
        public void Introduce(string to)
        {
            // Introductions are in order
            System.Console.WriteLine("Hello {0}, I am {1}!", to, Name);
        }

        public void SetBirthDate(DateTime birthDate)
        {
            _birthDate = birthDate;
        }

        public DateTime GetBirthDate()
        {
            return _birthDate;
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
            var person = new Person
            {
                Name = str
            };

            // Return the person object
            return person;
        }
    }
}
