using System;

namespace CompanyInfo
{
    class CompanyInfo
    {
        static void Main()
        {
            string companyName = Console.ReadLine();
            string companyAdress = Console.ReadLine();
            string phoneNumber = Console.ReadLine();
            string faxnumber = Console.ReadLine();
            string webSite = Console.ReadLine();
            string managerFirstName = Console.ReadLine();
            string managerLastName = Console.ReadLine();
            int managerAge = int.Parse(Console.ReadLine());
            string managerPhone = Console.ReadLine();

            Console.WriteLine(companyName);
            Console.WriteLine("Address: " + companyAdress);
            Console.WriteLine("Tel. " + phoneNumber);
            Console.WriteLine("Fax: {0}", faxnumber.Length == 0 ? "(no fax)" : faxnumber);
            Console.WriteLine("Web site: " + webSite);
            Console.WriteLine("Manager: {0} {1} (age: {2}, tel. {3})", managerFirstName, managerLastName, managerAge, managerPhone);


        }
    }
}
