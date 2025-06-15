using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_2_
{
    public class MainClass
    {
        public static void Main(string[] args)
        {
            string str = "ucdyk:кпкпук"; //Инициализация строки
            int colonIndex = str.IndexOf(':'); //Поиск индекса двоеточия

            if (colonIndex != -1) //Проверка, найдено ли двоеточие
            {
                Console.WriteLine("Количество знаков перед двоеточием: " + colonIndex); //Двоеточие найдено
            }
            else
            {
                Console.WriteLine("В строке нет двоеточия."); //Двоеточие не найдено 

            }
            
        }
    }
}
