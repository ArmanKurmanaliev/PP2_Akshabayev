using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W4G1_Example2
{
    [Serializable]
    public class Subject
    {
        public string name;

        public Subject() { }

        public Subject(string _name)
        {
            name = _name;
        }
    }
}