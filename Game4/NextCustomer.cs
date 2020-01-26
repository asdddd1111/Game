using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game4
{
    public class NextCustomer
    {
        public List<Customer> Get(List<Customer> customers, List<Employee> nextEmployee)
        {
            PositionOnMap positionOnMap = new PositionOnMap();
            for (int i = 0; i < customers.Count; i++)
            {
                for (int j = 0; j < nextEmployee.Count; j++)
                {
                    if (customers[i].Position.X == nextEmployee[j].Position.X && customers[i].Position.Y == nextEmployee[j].Position.Y)
                    {
                        customers[i].Position=positionOnMap.GetPoints(customers.Count)[i];
                    }
                }
            }
            return customers;
        }
    }
}
