namespace CSharpFundamentals
{
    public class Person
    {
        public string Name;

        public void Introduce(string to)
        {
            System.Console.WriteLine("Hello {0}, I am {1}!", to, Name);
        }

        public static Person Parse(string str)
        {
            var person = new Person();
            person.Name = str;

            return person;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person
            {
                Name = "Thing 1"
            };

            person.Introduce("Thing 2");

            var person2 = Person.Parse("King Thing");
            person2.Introduce("Super Thing");
        }
    }
}
