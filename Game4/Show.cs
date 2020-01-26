using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game4
{
    public class Show
    {
        public void Get(List<Employee> employees, char[,] map)
        {
            Console.Clear();
            int size = 19;
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Console.Write(map[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            foreach (var list in employees)
            {
                if (list is Worker)
                {
                    Console.WriteLine("Post: Worker; Name: {0}; Salary: {1}; Position: ({2} , {3});", list.Name, list.Salary, list.Position.X, list.Position.Y);
                }
                else
                {
                    if (list is Boss)
                    {
                        if ((list as Boss) is BigBoss)
                        {
                            Console.WriteLine("Post: BigBos; Name: {0}; Salary: {1}; Position: ({2} , {3});", list.Name, list.Salary, list.Position.X, list.Position.Y);
                        }
                        else
                        {
                            Console.WriteLine("Post: Boss; Name: {0}; Salary: {1}; Position: ({2} , {3});", list.Name, list.Salary, list.Position.X, list.Position.Y);
                        }
                    }
                }
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
