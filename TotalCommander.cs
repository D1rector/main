using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager
{
    class TotalCommander
    {
        private static string command = "menu";
        public static string newTask;
        public static void wait(string command)
        {
            string type;
            string title;
            string description;
            switch (command)
            {
                case "menu":
                    Console.WriteLine("МЕНЮ:\n" +
                        "1. Посмотреть задания\n" +
                        "2. Добавить задание\n"+
                        "3. Удалить задание\n"+
                        "4. Редактировать\n"+
                        "5. Выйти\n");
                    command = Console.ReadLine();
                    if (command == "1")//Реагируем на выбор пользователя
                    {
                        goto case "1";
                    }
                    if (command == "2")
                    {
                        goto case "2";
                    }
                    if (command == "3")
                    {
                        goto case "3";
                    }
                    if (command == "4")
                    {
                        goto case "4";
                    }
                    if (command == "5")
                    {
                        goto case "5";
                    }
                    else
                    {
                        Console.WriteLine("Неправильный ввод, пожалуйста, введите корректное число.");//если не то что нам надо, то возвращаемся в меню
                        TotalCommander.wait("menu");
                    }
                        break;

                case "1":
                    for (int i = 0; i < Program.taskList.Count; i++)
                    {
                        Console.WriteLine(Program.taskList[i].ViewAll);
                    }
                    Console.WriteLine("\n");
                    TotalCommander.wait("menu");//возвращаемся в меню
                    break;
                case "2":
                    Console.WriteLine("Введите тип");
                    type = Console.ReadLine();
                    Console.WriteLine("Введите заглавие");
                    title = Console.ReadLine();
                    Console.WriteLine("Введите описание");
                    description = Console.ReadLine();
                    task testTask = new task(type, title, description);
                    Program.taskList.Add(testTask);
                    Console.ReadLine();
                    TotalCommander.wait("menu");//возвращаемся в меню
                    break;
                case "3":
                    for (int i = 0; i < Program.taskList.Count; i++)
                    {
                        Console.WriteLine($"{i}: {Program.taskList[i].ViewAll}");
                    }
                    Console.WriteLine("\n");
                    Console.WriteLine("Введите номер задания, которое хотите удалить");
                    int deletedTask = System.Convert.ToInt32(Console.ReadLine());
                    if (deletedTask <= Program.taskList.Count && deletedTask >= 0)
                    {
                        Program.taskList.RemoveAt(deletedTask);
                        TotalCommander.wait("menu");//возвращаемся в меню
                    }
                    else
                    {
                        Console.WriteLine($"Не удалось удалить задание под номером {deletedTask}");
                        TotalCommander.wait("menu");
                    }
                    break;
                case "4":
                    for (int i = 0; i < Program.taskList.Count; i++)
                    {
                        Console.WriteLine($"{i}: {Program.taskList[i].ViewAll}");
                    }
                    Console.WriteLine("\n");
                    Console.WriteLine("Введите номер задания, которое хотите отредактировать");
                    int numEditedTask = System.Convert.ToInt32(Console.ReadLine());
                    if (numEditedTask <= Program.taskList.Count && numEditedTask >= 0)
                    {
                        task editedTask = Program.taskList[numEditedTask];
                        Console.WriteLine(editedTask.ViewAll);
                        editedTask.SetAll();//Редактируем
                        TotalCommander.wait("menu");//возвращаемся в меню
                    }
                    else
                    {
                        Console.WriteLine($"Не удалось найти задание под номером {numEditedTask}");
                        TotalCommander.wait("menu");
                    }
                    break;
                case "5":
                    if (Program.taskList.Count > 0)
                    {
                        Console.WriteLine("У вас здесь еще остались незавершенные дела.");
                        for (int i = 0; i < Program.taskList.Count; i++)
                        {
                            Console.WriteLine($"{i}. {Program.taskList[i].ViewAll}");
                            Console.ReadLine();
                        }
                        Console.WriteLine("Вы уверены что хотите выйти? (Y/N)");
                        string exitVerification = Console.ReadLine();
                        if (exitVerification == "Y")
                        {
                            return;
                        }
                        if (exitVerification == "N")
                        {
                            TotalCommander.wait("menu");
                        }

                    }
                    else
                    {
                        Console.WriteLine("Что ж, у вас нет ни одного задания. Прощайте...");
                        Console.ReadLine();
                    }
                    break;
                default:
                    break;
            }
        }

    }
}
