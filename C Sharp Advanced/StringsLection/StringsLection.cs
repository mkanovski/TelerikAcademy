using System;
using System.Text;

namespace StringsLection
{
    class StringsLection
    {
        static void Main()
        {
            string str1 = "az sym gosho";
            string str2 = "az sym pesho";


            // Compare strings
            String.Compare(str1, str2, true); // Сравнява без значение от Case-а на буквите
            String.Compare(str1, str2, false); // Сравнява като зачита Case-а на буквите

            // Concatanating strings

            //Търсене в String-ове
            str1.IndexOf(str2, 0); // Първо срещане
            str2.LastIndexOf(str2, 0); // Последно срещане

            // Вадене на парчета от стрингове
            str2.Substring(4); // реже от X индекс нататък
            str2.Substring(4, 5); //Реже от Х индекс, следващите Y индекси

            // Да взема индексите от 3 до 10
            str2.Substring(3, (10 - 3));

            //Сцепване на стринг по даден чар

            string[] arr = str1.Split(' ');

            // Премахване на празни стрингове при .Spilti()

            string[] arr1 = str1.Split(new char[] {' ', ',', '.'}, StringSplitOptions.RemoveEmptyEntries);
            // това може да се прави и със сепаратор стринг.
            string[] arr2 = str1.Split(new string[] {"ako", "gosho"}, StringSplitOptions.RemoveEmptyEntries);

            // Заместване и премахване
            string text = "this is some text texty stuff gosho penka ivan csharp javascript html gosho css";

            string newText = text.Replace("gosho", "marto"); // Винаги в нов стринг, защото стрингът не се променя

            // Махане на неща от стринг

            string textRemove = text.Remove(5); // Маха всичко от този индекс към края
            string textRemove1 = text.Remove(5, 7); // Маха следващите 7 символа от 5ти индекс нататък

            string textRemove2 = text.Remove(5, 12-5+1); // Режем от 5ти до 12ти (+1то е за да включи желанта последна позиция)

            string textSubString = text.Substring(text.Length - 4); // Взимаме последните 4 стъпки от стринг

            // Смяна от Lower към Upper case и обратното

            string caseText = "jfhsdJKHKJHjdkljdfGOSGO3487985aaaaaaBBBBBBccccccc";

            caseText.ToUpper(); // Прави всичко на главни букви
            caseText.ToLower(); // Прави всичко на малки букви

            // Стринг Trim

            caseText.Trim(); // Изчиства white spaces отпред и отзад на стринга
            caseText.Trim('-'); // Изчиства всички тирета отпред и отзад
            caseText.TrimStart(); //Изчиства white spaces отпред на стринга
            caseText.TrimEnd(); // Изчиства white spaces отзад на стринга
            caseText.TrimStart('-'); //Изчиства тирета отпред на стринга
            caseText.TrimEnd('-'); // Изчиства тирета отзад на стринга

            // StringBuilder

            StringBuilder result = new StringBuilder();
            result.Append("goshothosht");
            string resultFin = result.ToString();

        }
    }
}
