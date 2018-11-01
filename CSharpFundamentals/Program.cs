namespace CSharpFundamentals
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
            var person = new Person
            {
                Name = str
            };

            // Return the person object
            return person;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //  New instance of the person class for Thing 1
            var person = new Person
            {
                Name = "Thing 1"
            };
            //  Introduce Thing 1 to Thing 2
            person.Introduce("Thing 2");

            // Use Static Parse Method to create a new instance of
            // the person class.
            var person2 = Person.Parse("King Thing");
            //  Introduce King Thing to Super Thing
            person2.Introduce("Super Thing");
        }
    }
}
