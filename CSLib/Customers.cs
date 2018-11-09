using System.Collections.Generic;

namespace CSLib
{
    public class Customer
    {
        /// <summary>
        /// This is the Unique Identifier for the object
        /// </summary>
        public int Id;
        /// <summary>
        /// Sets the Name Field to a more user friendly name
        /// </summary>
        public string Name;
        /// <summary>
        /// Used to track a list of orders the customer is going to make
        /// </summary>
        public readonly List<Orders> Order;


        /// <summary>
        /// Default Object Initializer where the List Objects and other similar object
        /// must be initialzied.  ArrayList... List<string>.... 
        /// </summary>
        public Customer()
        {
            Order = new List<Orders>();
        }

        /// <summary>
        /// This cunstructor is used to set the id field.  Calling its base class
        /// to instantiate the new List of type Orders
        /// </summary>
        /// <param name="id"></param>
        public Customer(int id): this()
        {
            this.Id = id;
        }

        /// <summary>
        /// This construcotr is used to set both the id and name fields.  To prevent
        /// dupplication of code it calls the base class that accepts the id field which 
        /// in turn calls the actual base class construtor.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        public Customer(int id, string name) : this(id)
        {
            this.Name = name;
        }

        /// <summary>
        /// Promote User Business Logic
        /// </summary>
        public void Promote()
        {
            var rating = CalculateRating(excludeOrders: true);

            if(rating == 0)
                System.Console.WriteLine("Promoted to Level 1");
            else
                System.Console.WriteLine("Promoted to Level 2");

        }

        private int CalculateRating(bool excludeOrders)
        {
            return 0;
        }
    }
}
