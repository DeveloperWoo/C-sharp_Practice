using System.Collections.Generic;

namespace Constructor
{
    class Customer
    {
        public int Id;
        public string Name;
        public List<Order> Orders;

        //default or parameterless contructor
        public Customer()
        {
            Orders = new List<Order>();
        }

        //Contructor overloading
        public Customer(int id) : this()
        {
            this.Id = id;
        }

        //Contructor overloading
        public Customer(int id, string name) : this(id)
        {
            //this.Id = id;
            this.Name = name;
        }
    }
}
