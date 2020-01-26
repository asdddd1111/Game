using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game4
{
   public abstract class Employee
    {
        public string Name { get; set; }
        public decimal Salary { get; set; }
        public Point Position { get; set; }
        public bool Mood { get; set; }
        public string Say(string whatToSay)
        {
            return whatToSay;
        }
        public string Talk(Employee ee)
        {
            return ee.GetType().Name;
        }
    }
}
