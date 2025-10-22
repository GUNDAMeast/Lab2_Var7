using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMV_Lab2_Var7
{
    public class Employee
    {
        public string Name { get; set; }
        public Department Department { get; set; }

        public Employee(string name, Department department)
        {
            Name = name;
            Department = department;
            department.Employees.Add(this);
        }

        public void ChangeDepartment(Department newDepartment)
        {
            Department = newDepartment;
            newDepartment.Employees.Add(this);
        }

        public Employee[] GetDepartmentEmployees ()
        {
            return Department.Employees.ToArray();
        }

        //повышение сотрудника до начальника
        //public void AssignHead()
        //{
        //    Department.Head = this;
        //}

        //
        // Department.Head = Employee

        public override string ToString()
        {
            //Department.Head ?? "не назначен"
            if (Department.Head == this) return $"{Name} начальник отдела {Department.Title}";
            else return $"{Name} работает в отделе {Department.Title}, начальник которого {Department.Head}";
        }
    }
}
