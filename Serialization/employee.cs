using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serialization
{
    [Serializable]
    internal class employee
    {
        public int id;
        public string name;
        public int basicsalary;
        public employee(int id, string name, int basicsalary)
        {
            this.id = id;
            this.name = name;
            this.basicsalary = basicsalary;
        }



    }
}
