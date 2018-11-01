using CSLib;

namespace CSharpFundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            IntroductionToClasses();
        }

        private static void IntroductionToClasses()
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
