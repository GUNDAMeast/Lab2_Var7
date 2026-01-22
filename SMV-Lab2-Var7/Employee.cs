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

            if (!Department.Employees.Contains(this))
            {
                department.Employees.Add(this);
            }
        }

        public void ChangeDepartment(Department newDepartment)
        {
            if (newDepartment == Department)
            {
                return;
            }
            if (Department != null)
            {
                Department.Employees.Remove(this);
                if (Department.Head == this)
                {
                    Department.Head = null;
                }
            }
            Department = newDepartment;
            if (!newDepartment.Employees.Contains(this))
            {
                newDepartment.Employees.Add(this);
            }            
        }

        public Employee[] GetDepartmentEmployees ()
        {
            if (Department == null)
            {
                return Array.Empty<Employee>();
            }
            return Department.Employees.ToArray();
        }

        //повышение сотрудника до начальника
        public void AssignHead()
        {
            if (Department == null)
            {
                throw new InvalidOperationException("Сотрудник не привязан к отделу!");
            }
            Department.Head = this;
        }

        public override string ToString()
        {
            if (Department == null)
            {
                return $"{Name} сейчас не прикреплён ни к какому отделу";
            }

            string headName = Department.Head == null
                ? "не назначен"
                : Department.Head == this
                    ? "сам сотрудник"
                    : Department.Head.Name;

            if (Department.Head == this) return $"{Name} начальник отдела {Department.Title}";
            else return $"{Name} работает в отделе {Department.Title}, начальник которого {headName}";
        }
    }
}
