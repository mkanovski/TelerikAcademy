using System;

namespace DefineClassesPart1
{
    class Startup
    {
        static void Main()
        {
            var monkeyTanya = new Monkey("Tanya", FurColor.Green , 25);

            monkeyTanya.Introduce();

            
        }
    }

    public class Monkey
    {
        private FurColor furColor; // Полетата, които този клас може да има
        private string name;
        private int age;

        public Monkey(string name, FurColor furColor, int age) // конструктор
        {
            this.furColor = furColor; // this Казва да се използват нещата подадени в този конструктор
            this.name = name;
            this.age = age;
        }

        public void Introduce() // Метод (функция) на класа
        {
            Console.WriteLine("My name is {0}, I am {1} years old and my fur's color is {2}", this.name, this.age, this.furColor);
        }

    }

    public enum FurColor
    {
        Red = 1,
        Green = 2,
        Blue = 3,
        Mixed = 4
    }
}
