using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game4
{
    public class ListEmployee
    {
        public List<Employee> GetEmployees()
        {
            int size = 10;
            PositionOnMap positionOnMap = new PositionOnMap();
            List<Employee> employees = new List<Employee>()
            {
                new Worker{Name="Bob", Mood=true, Salary=1000, Position=positionOnMap.GetPoints(size)[0] },
                new Worker{Name="Das", Mood=false, Salary=2000, Position=positionOnMap.GetPoints(size)[1] },
                new Worker{Name="Rob", Mood=true, Salary=3000, Position=positionOnMap.GetPoints(size)[2] },
                new Worker{Name="Cob", Mood=true, Salary=4000, Position=positionOnMap.GetPoints(size)[3] },
                new Worker{Name="Seb", Mood=false, Salary=5000, Position=positionOnMap.GetPoints(size)[4] },
                new Worker{Name="Gob", Mood=true, Salary=6000, Position=positionOnMap.GetPoints(size)[5] },
                new Boss{Name="Kob", Mood=false, Salary=7000, Position=positionOnMap.GetPoints(size)[6] },
                new Boss{Name="Lon", Mood=true, Salary=8000, Position=positionOnMap.GetPoints(size)[7] },
                new Boss{Name="Nom", Mood=false, Salary=9000, Position=positionOnMap.GetPoints(size)[8] },
                new BigBoss{Name="Vud", Mood=true, Salary=10000, Position=positionOnMap.GetPoints(size)[9] }
            };
            return employees;
        }
    }
}
