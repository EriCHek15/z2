using System;
using System.Text.RegularExpressions;

namespace z1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ввод строки
            Console.WriteLine("Введите исходную строку");
            string a = Console.ReadLine();

            Regex str = new Regex(@"[А-Я]\S*");//создание новой строки, где слово начинается только с заглавной буквы

            //вывод элементов, удовлетворяющих условию
            foreach (var i in str.Matches(a))
            {

                Console.WriteLine(i);

            }    
            

        }
    }
}
