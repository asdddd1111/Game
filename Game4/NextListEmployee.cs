using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game4
{
    public class NextListEmployee
    {
        public List<Employee> Get(List<Customer> customers,List<Employee> employees)
        {
            NextPosition nextPosition = new NextPosition();
            for (int i=0;i<employees.Count;i++)
            {
                employees[i].Position = nextPosition.Get(employees)[i];
                for (int j = 0; j < customers.Count; j++)
                {
                    if (customers[j].Position.X == nextPosition.Get(employees)[i].X && customers[j].Position.Y == nextPosition.Get(employees)[i].Y)
                    {
                        employees[i].Salary += customers[j].Price;
                    }
                }
            }
            return employees;
        }
    }
}
