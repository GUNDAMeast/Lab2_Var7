//Вариант 7
// Задание 1 - 3,4

using SMV_Lab2_Var7;

//string employName = Console.ReadLine();
//string depname = Console.ReadLine();
//Department(depname).ToString();

//Employee


var it = new Department("IT");
var math = new Department("Math");

var petrov = new Employee("Петров", it);
var ivanov = new Employee("Иванов", it);
var sidorov = new Employee("Сидоров", it);
var victor = new Employee("Виктор", math);

it.Head = petrov;

/*
Console.WriteLine(it);
Console.WriteLine(petrov);
Console.WriteLine(ivanov);
Console.WriteLine(sidorov);
Console.WriteLine(victor);

Console.WriteLine("\nВсе сотрудники отдела:");
foreach (var emp in math.Employees)
    Console.WriteLine($"- {emp.Name}");
*/

/*
Employee[] teamOfPetrov = petrov.GetDepartmentEmployees();

Console.WriteLine($"Сотрудники отдела {petrov.Department.Title} (через ссылку на Петрова):");
foreach (var e in teamOfPetrov)
    Console.WriteLine(" - " + e.Name);

Console.WriteLine();
Employee[] teamOfBoss = ivanov.GetDepartmentEmployees();
Console.WriteLine($"Сотрудники отдела {ivanov.Department.Title} (через ссылку на начальника):");
foreach (var e in teamOfBoss)
    Console.WriteLine(" - " + e.Name);

Console.WriteLine();
Console.WriteLine($"Сотрудники отдела {sidorov.Department.Title} (через ссылку на Сидорова):");
foreach (var e in sidorov.GetDepartmentEmployees())
    Console.WriteLine(" - " + e.Name);

Console.WriteLine();
Console.WriteLine($"Сотрудники отдела {victor.Department.Title} (через ссылку Виктора):");
foreach (var e in victor.GetDepartmentEmployees())
    Console.WriteLine(" - " + e.Name);

Console.WriteLine("\nГотово");
*/