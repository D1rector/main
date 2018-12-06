using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager
{
    enum typeOfTasks {
        study,
        parents,
        job
    }
    class task//кастомный класс для списка задач
    {
        public task(string Type, string Title, string Description)
        {
            CreationTime = DateTime.Now;
            this.Type = Type;
            this.Title = Title;
            this.Description = Description;

        }
        public void SetAll()
        {
            string type;
            string title;
            string description;
            Console.WriteLine("Введите тип");
            type = Console.ReadLine();
            if (type == "")
            {
                type = this.Type;
            }
            Console.WriteLine("Введите заглавие");
            title = Console.ReadLine();
            if (title == "")
            {
                title = this.Title;
            }
            Console.WriteLine("Введите описание");
            description = Console.ReadLine();
            if (description == "")
            {
                description = this.Description;
            }
            this.Type = type;
            this.Title = title;
            this.Description = description;
        }
        public string Type { get; set; }//свойства
        public string Title { get; set; }
        public string Description { get; set; }
        public System.DateTime CreationTime { get; set; }
        public string ViewAll {//Метод "Показать все"
            get {
                return $"{this.CreationTime} - Тип: [{this.Type}] Название: [{this.Title}] Описание: [{this.Description}]";
            }
        }
        public System.DateTime dateNow = DateTime.Now;

    }
}
