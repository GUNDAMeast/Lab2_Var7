using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMV_Lab2_Var7
{
    internal class Lab2TasksInputCheck
    {
        InputCheck checkmas = new InputCheck();
        public void Task_1_4_CheckFIO()
        {
            string fio;
            var newPersonName = new PersonName();
            Console.WriteLine("Введите ФИО:");
            fio = Console.ReadLine();
            string[] splitFIO = fio.Split(' ');

            if (splitFIO[0] == "")
            {
                Console.WriteLine("ФИО было введено неверно!");
            }
            else
            {
                switch (splitFIO.Length)
                {
                    case 1:
                        newPersonName = new PersonName(splitFIO[0]);
                        Console.Write("Через ToString(): ");
                        Console.WriteLine(newPersonName.ToString());
                        break;
                    case 2:
                        newPersonName = new PersonName(splitFIO[0], splitFIO[1]);
                        Console.Write("Через ToString(): ");
                        Console.WriteLine(newPersonName.ToString());
                        break;
                    case 3:
                        newPersonName = new PersonName(splitFIO[0], splitFIO[1], splitFIO[2]);
                        Console.Write("Через ToString(): ");
                        Console.WriteLine(newPersonName.ToString());
                        break;

                    default:
                        Console.WriteLine("ФИО было введено неверно!");
                        break;
                }
            }
            Console.WriteLine();
        }

        public void Task_3_4_Employees()
        {
            int index;
            Console.WriteLine("Введите название нового отдела: ");
            var department = new Department(Console.ReadLine());
            Console.WriteLine("Создаём массив сотрудников: ");

            Console.WriteLine("Введите количество элементов в массиве:");
            Employee[] mas = new Employee[checkmas.CheckIntForMas()];
            for (int i = 0; i < mas.Length; i++)
            {
                if (i == 0) Console.WriteLine("Введите начальника: ");
                else Console.WriteLine("Введите сотрудника номер " + i + ": ");
                mas[i] = new Employee(Console.ReadLine(), department);
            }
            mas[0].AssignHead();
            Console.WriteLine();
            foreach (var str in mas)
            {
                Console.WriteLine(str);
            }
            Console.WriteLine();

            Console.WriteLine("Ссылка на какого сотрудника у нас имеется?");
            index = checkmas.CheckInt();
            while (checkmas.IsInRange(0, mas.Length-1, index) == false)
            {
                Console.WriteLine("В отделе нет сотрудника с таким номером!");
                Console.WriteLine("Ссылка на какого сотрудника у нас имеется?");
                index = checkmas.CheckInt();
                checkmas.IsInRange(0, mas.Length, index);
            }
            Employee[] teamOfMasIndex = mas[index].GetDepartmentEmployees();
            Console.WriteLine($"Сотрудники отдела {mas[index].Department.Title} (через ссылку на сотрудника номер "+index+" ("+ mas[index].Name +")):");
            foreach (var e in teamOfMasIndex)
                Console.WriteLine(" - " + e.Name);
        }

        public void Task_5_4_Time()
        {
            DayTime newTime = new DayTime(0);
            string answer;
            Console.WriteLine("Как вы хотите ввести время как секунды (0) или укажете количество часов, минут и секунд (1)?");
            answer = Console.ReadLine();
            switch (answer)
            {
                case "0":
                    Console.WriteLine("\nВведите количество секунд:");
                    newTime = new DayTime(checkmas.CheckIntPlus());
                    Console.WriteLine(newTime.ToString() + "\n");
                    Console.WriteLine("Прошло часов: " + newTime.HoursPassed);
                    Console.WriteLine("Прошло минут: " + newTime.MinutesPassed);
                    Console.WriteLine("Прошло секунд: " + newTime.SecondsPassed);
                    break;
                
                case "1":
                    Console.WriteLine("\nВведите количество часов:");
                    int h = checkmas.CheckIntPlus();
                    Console.WriteLine("\nВведите количество минут:");
                    int m = checkmas.CheckIntPlus();
                    Console.WriteLine("\nВведите количество секунд:");
                    int s = checkmas.CheckIntPlus();
                    newTime = new DayTime(h, m, s);
                    Console.WriteLine(newTime.ToString() + "\n");
                    Console.WriteLine("Прошло часов: " + newTime.HoursPassed);
                    Console.WriteLine("Прошло минут: " + newTime.MinutesPassed);
                    Console.WriteLine("Прошло секунд: " + newTime.SecondsPassed);
                    break;

                default:
                    Console.WriteLine("Выберите доступный способ ввода!");
                    break;
            }
        }
    }
}
