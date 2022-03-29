using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_1_1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Написать программу, выводящую в консоль текст: «Привет, %имя пользователя%, сегодня %дата%». 
            Имя пользователя сохранить из консоли в промежуточную переменную.
            Поставить точку останова и посмотреть значение этой переменной в режиме отладки. 
            Запустить исполняемый файл через системный терминал.*/
            Console.Write("Как вас зовут?");
            string name = Console.ReadLine();
            Console.WriteLine($"Привет, {name}, сегодня {DateTime.Now}");
        }
    }
}
