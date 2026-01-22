using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SMV_Lab2_Var7
{
    public class Department
    {
        public string Title { get; set; }
        public Employee Head { get; set; }
        public List<Employee> Employees { get; set; }

        public Department(string title)
        {
            Title = title;
            Employees = new List<Employee> ();
        }

        public override string ToString()
        {
            return $"Отдел: {Title}, Начальник: {Head.Name ?? "не назначен"}";
        }
    }
}
