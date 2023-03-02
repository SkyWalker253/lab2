using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Person Emil = new Person('m', "Emil", "Bildanov", new DateTime(2005, 11, 6));
            //Emil.Print();
            //Person Aydar = new Person();
            //Aydar.Input();
            //Aydar.Print();
            //Console.WriteLine(Emil.ToString());
            //Console.WriteLine(Emil.Nowage());

            Console.WriteLine("Введите количество людей:");
            int n = int.Parse(Console.ReadLine());

            Person[] arr = new Person[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Введите данные о {i + 1} человеке:");
                arr[i] = Person.Input();
            }

            Console.WriteLine("Люди:");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine($"Имя:{arr[i].Name}\nФамилия: {arr[i].Surname.Substring(0, 1)}\nВозраст: {arr[i].Nowage()}\nГенден: {arr[i].Gen}\n");
            }
        }
    }
}
