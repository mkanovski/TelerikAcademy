using System;

namespace Objects
{
    class Objects
    {
        static void Main()
        {
            Student pesho = new Student();

            pesho.firstName = "Pesho";
            pesho.lastName = "Goshev";

            Student gosho = new Student();

            gosho.firstName = "Gosho";
            gosho.lastName = "Peshov";


        }

    }
    // Създаване на класове
    class Student
    {
       public string firstName; // дефиниране на променливи за обекта Student

        public string lastName;

        public void ChangeName(string name) // дефиниране на поведение на обекта Student
        {
            firstName = lastName;
        }
    }
}
