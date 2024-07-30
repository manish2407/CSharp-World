using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexers
{
    public class Employee
    {   int ENo;
        double Salary;
        string EName, job, DName, Location;

        public Employee(int ENo, double Salary, string EName, string job, string DName, string Location)
        {
            this.ENo = ENo;
            this.Salary = Salary;
            this.EName = EName;
            this.job = job;
            this.DName = DName;
            this.Location = Location;
        }

        //indexer
        public object this[int index]
        {
            get
            {
                if (index == 0)
                    return ENo;
            else if(index == 1)
                    return Salary;
                else if (index == 2)
                    return EName;
                else if (index == 3)
                    return job;
                else if (index == 4)
                    return DName;
                else if(index == 5)
                    return Location;
                return null;
            }
            set
            {
                if(index == 0)
                {
                    ENo = (int)value;
                }
                else if(index == 1)
                {
                    Salary = (Double)value;
                }
                else if (index == 2)
                {
                    EName = (string)value;
                }
                else if (index == 3)
                {
                    job = (string)value;
                }
                else if (index ==4)
                {
                    DName = (string)value;
                }
                else if (index == 5){
                    Location = (string)value;
                }
            }
        }
    }
}
