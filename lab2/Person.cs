using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    internal class Person
    {
        private char gen;

        public string Name
        {
            get;
            set;
        }
        public string Surname
        {
            get;
            set;
        }
        public DateTime Bday
        {
            get;
            set;
        }
        public char Gen
        {
            get { return gen; }
            set { gen = value; }
        }
        public Person(char gen, string name, string surname, DateTime bday)
        {
            Gen = gen;
            Name = name;
            Surname = surname;
            Bday = bday;
        }
        public Person()
        {
        }
        public void Print()
        {
            Console.WriteLine($"Имя: {Name} Фамилия: {Surname} Дата рождения: {Bday} Пол: {Gen}");
        }
        public static Person Input()
        {
            Console.WriteLine("Введите имя:");
            string name = Console.ReadLine();
            Console.WriteLine("Введите фамилию: ");
            string surname = Console.ReadLine();
            Console.WriteLine("Введите дату рождения через точку: ");
            DateTime bday = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Введите пол: ");
            char gen = Convert.ToChar(Console.ReadLine());
            return new Person(gen,name, surname, bday);
        }
        public override string ToString()
        {
            return ($"Фамилия: {Surname} Имя: {Name} Дата рождения: {Bday} Пол: {Gen}");
        }
        public int Nowage()
        {
            DateTime today = DateTime.Now;
            int age = today.Year - Bday.Year;
            if (today.Month == Bday.Month && today.Day < Bday.Day || today.Month < Bday.Month)
            { age--; }
            return age;
        }
    }
}
