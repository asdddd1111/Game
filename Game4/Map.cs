using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game4
{
    public class Map
    {
        public void Get()
        {
            int size = 19;
            Customer customer = new Customer();
            ListEmployee listEmployee = new ListEmployee();
            NextListEmployee nextListEmployee = new NextListEmployee();
            NextCustomer nextCustomer = new NextCustomer();
            List<Employee> employees = new List<Employee>();
            List<Customer> customers = new List<Customer>();
            customers = customer.Get().GetRange(0, customer.Get().Count);
            employees = listEmployee.GetEmployees().GetRange(0, listEmployee.GetEmployees().Count);
            int time = 26;
            while (time != DateTime.Now.Minute  )
            {
                char[,] map = new char[size, size];
                for (int i = 0; i < size; i++)
                {
                    for (int j = 0; j < size; j++)
                    {
                        map[i, j] = '0';
                    }
                }
                foreach (var list in employees)
                {
                    if (list is Worker)
                    {
                        map[list.Position.X, list.Position.Y] = 'W';
                    }
                    else
                    {
                        if (list is Boss)
                        {
                            if ((list as Boss) is BigBoss)
                            {
                                map[list.Position.X, list.Position.Y] = 'G';
                            }
                            else
                            {
                                map[list.Position.X, list.Position.Y] = 'B';
                            }
                        }
                    }
                }
                foreach (var list in customers)
                {
                    map[list.Position.X, list.Position.Y] = '$';
                }
                Show show = new Show();
                show.Get(employees, map);
                Mesage mesage = new Mesage();
                mesage.Get(employees);
                employees = nextListEmployee.Get(customers, employees).GetRange(0, employees.Count);
                customers = nextCustomer.Get(customers, nextListEmployee.Get(customers, employees)).GetRange(0, customers.Count);
            }
            
        }
    }
}
