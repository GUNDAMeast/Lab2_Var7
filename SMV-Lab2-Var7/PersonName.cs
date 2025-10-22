using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMV_Lab2_Var7
{
    public class PersonName
    {
        public string LastName { get; private set; }
        public string Name { get; private set; }
        public string Otchestvo { get; private set; }

        public PersonName(string lastName = "", string name = "", string otchestvo = "")
        {
            LastName = lastName ?? "";
            Name = name ?? "";
            Otchestvo = otchestvo ?? "";
        }

        public override string ToString()
        {
            return $"{LastName} {Name} {Otchestvo}".Trim();
        }
    }
}
