using CSLib;

namespace CSharpFundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            IntroductionToClasses();


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
