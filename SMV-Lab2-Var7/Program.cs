//Вариант 7

using SMV_Lab2_Var7;

var InputCheck = new InputCheck();
var Lab2TasksInputCheck = new Lab2TasksInputCheck();
bool stopTasks = false;
string answer;
var newPersonName = new PersonName();

//1.3

Console.WriteLine("\nЗадание 1.3\n");

var personName0 = new PersonName("Иванов", "Иван", "Иванович");
var personName1 = new PersonName("Клеопатра");
var personName2 = new PersonName("Пушкин", "Александр", "Сергеевич");
var personName3 = new PersonName("Маяковский", "Владимир");

Console.WriteLine(personName0.ToString());
Console.WriteLine(personName1.ToString());
Console.WriteLine(personName2.ToString());
Console.WriteLine(personName3.ToString());

Console.WriteLine();
stopTasks = false;
while (stopTasks == false)
{
    Console.WriteLine("Хотите ввести новое ФИО?");
    answer = Console.ReadLine();
    Console.Clear();
    switch (answer)
    {
        case "Нет":
        case "No":
        case "нет":
        case "no":
        case "0":
            stopTasks = true;
            break;

        case "Да":
        case "Yes":
        case "да":
        case "yes":
        case "1":
            Lab2TasksInputCheck.Task_1_4_CheckFIO();
            break;

        default:
            Console.WriteLine("Ответьте только 'Да' или 'Нет'!");
            break;
    }
}

//2.4

Console.WriteLine("\nЗадание 2.4\n");

var it = new Department("IT");

var petrov = new Employee("Петров", it);
var kozlov = new Employee("Козлов", it);
var sidorov = new Employee("Сидоров", it);

kozlov.AssignHead();

Console.WriteLine(petrov);
Console.WriteLine(kozlov);
Console.WriteLine(sidorov);

//3.4

Console.WriteLine("\nЗадание 3.4\n");

Employee[] teamOfPetrov = petrov.GetDepartmentEmployees();
Console.WriteLine($"Сотрудники отдела {petrov.Department.Title} (через ссылку на Петрова):");
foreach (var e in teamOfPetrov)
    Console.WriteLine(" - " + e.Name);

Console.WriteLine();
Console.WriteLine($"Сотрудники отдела {kozlov.Department.Title} (через ссылку на начальника (Козлова)):");
foreach (var e in kozlov.GetDepartmentEmployees())
    Console.WriteLine(" - " + e.Name);

Console.WriteLine();
Console.WriteLine($"Сотрудники отдела {sidorov.Department.Title} (через ссылку на Сидорова):");
foreach (var e in sidorov.GetDepartmentEmployees())
    Console.WriteLine(" - " + e.Name);

Console.WriteLine();
stopTasks = false;
while (stopTasks == false)
{
    Console.WriteLine("Хотите ввести сотрудников нового отдела?");
    answer = Console.ReadLine();
    Console.Clear();
    switch (answer)
    {
        case "Нет":
        case "No":
        case "нет":
        case "no":
        case "0":
            stopTasks = true;
            break;

        case "Да":
        case "Yes":
        case "да":
        case "yes":
        case "1":
            Lab2TasksInputCheck.Task_3_4_Employees();
            break;

        default:
            Console.WriteLine("Ответьте только 'Да' или 'Нет'!");
            break;
    }
}

//1.4

Console.WriteLine("\nЗадание 1.4\n");

var time0 = new DayTime(12000);
var time1 = new DayTime(91800);
var time2 = new DayTime(10);
var time3 = new DayTime(10000);
var time4 = new DayTime(100000);

Console.WriteLine("12000 секунд = " + time0.ToString());
Console.WriteLine("91800 секунд = " + time1.ToString());
Console.WriteLine("10 секунд = " + time2.ToString());
Console.WriteLine("10000 секунд = " + time3.ToString());
Console.WriteLine("100000 секунд = " + time4.ToString());

//4.4

Console.WriteLine("\nЗадание 4.4\n");

var time5 = new DayTime(2,3,5);
Console.WriteLine("2 часа, 3 минуты, 5 секунд = " + time5.ToString());

//5.4

Console.WriteLine("\nЗадание 5.4\n");

var time6 = new DayTime(34056);
Console.WriteLine("34056 секунд = " + time6.ToString());
Console.WriteLine("Прошло часов: " + time6.HoursPassed);
Console.WriteLine("Прошло минут: " + time6.MinutesPassed);
Console.WriteLine("Прошло секунд: " + time6.SecondsPassed);

Console.WriteLine();
var time7 = new DayTime(4532);
Console.WriteLine("4532 секунд = " + time7.ToString());
Console.WriteLine("Прошло часов: " + time7.HoursPassed);
Console.WriteLine("Прошло минут: " + time7.MinutesPassed);
Console.WriteLine("Прошло секунд: " + time7.SecondsPassed);

Console.WriteLine();
var time8 = new DayTime(123);
Console.WriteLine("123 секунд = " + time8.ToString());
Console.WriteLine("Прошло часов: " + time8.HoursPassed);
Console.WriteLine("Прошло минут: " + time8.MinutesPassed);
Console.WriteLine("Прошло секунд: " + time8.SecondsPassed);

Console.WriteLine();
stopTasks = false;
while (stopTasks == false)
{
    Console.WriteLine("Хотите ввести своё время?");
    answer = Console.ReadLine();
    Console.Clear();
    switch (answer)
    {
        case "Нет":
        case "No":
        case "нет":
        case "no":
        case "0":
            stopTasks = true;
            break;

        case "Да":
        case "Yes":
        case "да":
        case "yes":
        case "1":
            Lab2TasksInputCheck.Task_5_4_Time();
            break;

        default:
            Console.WriteLine("Ответьте только 'Да' или 'Нет'!");
            break;
    }
}