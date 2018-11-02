using System.Collections.Generic;

namespace CSLib
{
    public class Customer
    {
        public int Id;
        public string Name;
        public List<Orders> Orders;

        public Customer()
        {
            Orders = new List<Orders>();
        }

        public Customer(int id): this()
        {
            this.Id = id;
        }

        public Customer(int id, string name) : this(id)
        {
            this.Name = name;
        }
    }
}
