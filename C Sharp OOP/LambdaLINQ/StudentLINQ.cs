using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaLINQ
{
    // Class Student used in many problems:
    public class Student
    {
        public string firstName;
        public string lastName;
        public int age;
        public int facultyNumber;
        public string phoneNumber;
        public string emailAddress;
        public List<int> marks;
        public int groupNumber;

        public int GroupNumber { get; set; }

        public Student(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }

        public Student(string firstName, string lastName, int age)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
        }

        public Student(string firstName, string lastName, int facultyNumber, string phoneNumber, string emailAddress, List<int> marks, int groupNumber)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.facultyNumber = facultyNumber;
            this.phoneNumber = phoneNumber;
            this.emailAddress = emailAddress;
            this.marks = new List<int>();
            this.marks = marks;
            this.groupNumber = groupNumber;
        }
    }

    // Problem 3: Method to return all Students who's last name is lexicographically before his first name
    public class Problem3
    {
        public static Student[] FirstBeforeLast(Student[] array)
        {
            List<Student> result = array.ToList();

            result = result.FindAll(x => (string.Compare(x.firstName, x.lastName) == -1)).ToList();

            return result.ToArray();                       
            
        }
    }

    //Problem 4: Return the first and last name of all students in 18 - 24 age range

    public class Problem4
    {
        public static Student[] ReturnNamesBetween1824(Student[] array)
        {
            

            var result = from x in array
                     where x.age >= 18 && x.age <= 24
                     select new
                     {
                         x.firstName,
                         x.lastName
                     };

            Student[] students = new Student[result.Count()];
            int index = 0;

            foreach (var student in result)
            {
                students[index] = new Student(student.firstName, student.lastName);
                index++;
            }

            return students;

        }
    }

    //Problem 5: OrederBy() Student.firstname, ThenBy() Student.lastname

    public class Problem5
    {
        public static Student[] OrderByFirstNameThenByLastName(Student[] array)
        {
            Student[] result = array.OrderBy(x => x.firstName).ThenBy(x => x.lastName).ToArray();

            return result;
        }
    }

    // Problem 9: Student groups

    public class Problem9
    {
        public List<Student> students;

        Student pesho = new Student("Pesho", "Peshov", 11111, "0888 33 44 55", "pesho@pesho.com", new List<int> { 4, 4, 5, 6 }, 2);

        Student gosho = new Student("Gosho", "Goshov", 22222, "0888 11 54 66", "gosho@gosho.com", new List<int> { 4, 4, 5, 6 }, 1);

        Student stamat = new Student("Stamat", "Stamatov", 11111, "0888 54 21 32", "stamat@stam.com", new List<int> { 4, 4, 5, 6 }, 2);

        public Problem9()
        {
            this.students = new List<Student>();
            this.students.Add(pesho);
            this.students.Add(gosho);
            this.students.Add(stamat);
        }

        public List<Student> ReturnOnlyGroup2(List<Student> list)
        {
            var filteredStudents = from student in this.students
                         where student.groupNumber == 2
                         select student;

            List<Student> result = new List<Student>();

            foreach (var item in filteredStudents)
            {
                result.Add(item);
            }

            return result;
        }

        public List<Student> OrderByFirstName(List<Student> list)
        {
            var ordered = list.OrderBy(x => x.firstName);

            List<Student> result = new List<Student>();

            foreach (var item in ordered)
            {
                result.Add(item);
            }

            return result;
        }



    }

    // Problem 10: Implement the previous using the same query expressed with extension methods.

    public static class Problem10
    {
        public static List<Student> OrderByFirstName(this List<Student> list)
        {
            var ordered = list.OrderBy(x => x.firstName);

            List<Student> result = new List<Student>();

            foreach (var item in ordered)
            {
                result.Add(item);
            }

            return result;
        }
    }

    //Problem 11: Extract all students that have email in abv.bg

    public class Problem11
    {
        public static List<Student> ReturnOnlyStudentsWithAbvEmails(List<Student> list)
        {
            var filtered = list.Where(x => x.emailAddress.Contains("@abv.bg")).ToList();

            return filtered;
        }
    }

    //Problem 12: Extract all students that have phone number in Sofia
    //(Begins with 02 (phone num format "[area code] [number]")

    public class Problem12
    {
        public static List<Student> ReturnOnlyStudentsWithSofiaPhoneNumbers(List<Student> list)
        {
            var filtered = list.Where(x => (x.phoneNumber.Substring(0, 3) == "02 ")).ToList();

            return filtered;
        }
    }

    //Problem 13: Select all students that have at least one mark Excellent (6)
    //into a new anonymous class that has properties – FullName and Marks.

    public class Problem13
    {
        public static List<object> FilterAllAtudentsWithAtLeastOne6Mark(List<Student> list)
        {
            var result = from student in list
                         where (student.marks.IndexOf(6) != -1)
                         select new
                         {
                             FullName = $"{student.firstName} {student.lastName}",
                             Marks = student.marks
                         };

            List<object> objects = new List<object>();

            foreach (var item in result)
            {
                objects.Add(item);
            } 

            return objects;
        }
    }

    //Problem 14: Write down a similar program that extracts the students with exactly two marks "2".

    public class Problem14
    {

        public static bool AreThereTwo2Marks(Student student)
        {
            int count = 0;

            foreach (var item in student.marks)
            {
                if(item == 2)
                {
                    count++;
                }
            }

            if(count == 2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
              

        public static List<Student> FilterAllStudentsWithTwo2Marks(List<Student> list)
        {
            var result = from student in list
                         where (AreThereTwo2Marks(student) == true)
                         select student;
                         

            List<Student> students = new List<Student>();

            foreach (var item in result)
            {
                students.Add(item);
            }

            return students;
        }
    }

    //Problem 15: Extract all Marks of the students that enrolled in 2006.
    //(The students from 2006 have 06 as their 5-th and 6-th digit in the FN).

    public class Problem15
    {
        public static List<Student> ExtractMarksFor2006Students(List<Student> list)
        {
            var filtered = from student in list
                         where student.facultyNumber % 100 == 6
                         select student;

            List<Student> result = new List<Student>();

            foreach (var item in filtered)
            {
                result.Add(item);
            }

            return result;
        }
    }

    //Problem 18: Create a program that extracts all students grouped by GroupNumber and then prints them to the console.

    public class Problem18
    {
        public void PrintAllStudentsGroupedByGroupName(List<Student> list)
        {
            var groupsStudents = from student in list
                                 group student by student.GroupNumber into groups
                                 select groups;

            foreach (var item in groupsStudents)
            {
                Console.WriteLine(item.Key);
                foreach (var student in item)
                {
                    Console.WriteLine(student.firstName + " " + student.lastName);
                }
            } 
        }
    }


}
