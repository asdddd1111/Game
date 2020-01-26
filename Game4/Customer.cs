using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game4
{
    public class Customer
    {
        public Point Position { get; set; }
        public decimal Price { get; set; }
        public List<Customer> Get()
        {
            int size = 10;
            int minPrice = 100;
            int maxPrice = 1000;
            PositionOnMap positionOnMap = new PositionOnMap();
            List<Customer> customers = new List<Customer>();
            for (int i = 0; i < size; i++)
            {
                customers.Add(new Customer{Price=RandomNumber.Get(minPrice,maxPrice), Position=positionOnMap.GetPoints(size)[i]});
            }
            return customers;
        }
    }
}
