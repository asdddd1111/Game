using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game4
{
    public class Mesage
    {
        public void Get(List<Employee> employees)
        {
            string whatToSay1 = "Hi";
            string whatToSay2 = "Hello";
            Worker worker = new Worker();
            Boss boss = new Boss();
            BigBoss bigBoss = new BigBoss();
            for (int i = 0; i < employees.Count; i++)
            {
                for (int j = 0; j < employees.Count; j++)
                {
                    if (employees[i].Position.X == employees[j].Position.X && employees[i].Position.Y == employees[j].Position.Y&&i!=j)
                    {
                        if ((employees[i] is Worker) && (employees[j] is Worker))
                        {
                            Console.WriteLine("{0} {1} {2}", worker.Say(whatToSay1), employees[i].Name, worker.Talk(worker));
                            Console.WriteLine();
                            Console.WriteLine("{0} {1} {2}", worker.Say(whatToSay1), employees[j].Name, worker.Talk(worker));
                        }
                        else
                        {
                            if ((employees[i] is Boss) && (employees[j] is Boss))
                            {
                                if ((employees[j] as Boss) is BigBoss)
                                {
                                    Console.WriteLine("{0} {1} {2}", boss.Say(whatToSay2), employees[i].Name, boss.Talk(boss));
                                    Console.WriteLine();
                                    Console.WriteLine("{0} {1} {2}", bigBoss.Say(whatToSay2), employees[j].Name, bigBoss.Talk(bigBoss));
                                }
                                else
                                {
                                    Console.WriteLine("{0} {1} {2}", boss.Say(whatToSay1), employees[i].Name, boss.Talk(boss));
                                    Console.WriteLine();
                                    Console.WriteLine("{0} {1} {2}", boss.Say(whatToSay1), employees[j].Name, boss.Talk(boss));
                                }
                            }
                            else
                            {
                                if ((employees[i] is Worker) && (employees[j] is Boss))
                                {
                                    if ((employees[j] as Boss) is BigBoss)
                                    {
                                        Console.WriteLine("{0} {1} {2}", bigBoss.Say(whatToSay2), employees[j].Name, bigBoss.Talk(bigBoss));
                                        Console.WriteLine();
                                        Console.WriteLine("{0} {1} {2}", worker.Say(whatToSay2), employees[i].Name, worker.Talk(worker));
                                    }
                                    else
                                    {
                                        Console.WriteLine("{0} {1} {2}", boss.Say(whatToSay2), employees[j].Name, boss.Talk(boss));
                                        Console.WriteLine();
                                        Console.WriteLine("{0} {1} {2}", worker.Say(whatToSay2), employees[i].Name, worker.Talk(worker));
                                    }
                                    
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
