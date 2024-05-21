using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CrudeUsingCollection
{
    internal class Employee1 :IComparable<Employee1>
    {
        public string name;
        public int sallary;
        public Employee1(string name ,int sallary)
        {
            this.name = name;
            this.sallary = sallary;

        }

        public int CompareTo(Employee1 other)
        {
            if (this.sallary > other.sallary)
            {
                return 1;
            }
            else if (this.sallary< other.sallary)
            { 
                        
                return -1;
            }
            else
            {
                return 0;
            }
         
        }
        public override string ToString()
        {
            return $"name {name} ,sallary {sallary}";
            
        }
    }
   
    
}
