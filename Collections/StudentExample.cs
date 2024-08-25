using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    public class StudentExample : IComparable<StudentExample>
    {
        
        public int StudentId { get; set; }
        public string Name { get; set; }
        public int Class { get; set; }
        public double Marks { get; set; }

        //For the acsending order
        public int CompareTo(StudentExample other)
        {
            if (this.StudentId > other.StudentId)
                return 1;
            else if(this.StudentId < other.StudentId)
                return -1;
            else 
                return 0;
        }
        /*For the descending order
         * public int CompareTo(StudentExample other)
        {
            if (this.StudentId > other.StudentId)
                return -1;
            else if(this.StudentId < other.StudentId)
                return 1;
            else 
                return 0;
        }*/
    }

    //For the Pre defined class and dont have the sorce code of the class then 
    class CompareStudent : IComparer<StudentExample>
    {
        public int Compare(StudentExample x, StudentExample y)
        {
            if (x.Marks > y.Marks)
                return 1;
            else if (x.Marks < y.Marks)
                return -1;
            else
                return 0;
        }
    }
    public class SImplementation
    {
        public static int CompareNames(StudentExample x, StudentExample y)
        {
            return x.Name.CompareTo(y.Name);
        }
        public static void Main(string[] args)
        {
            StudentExample s1 = new StudentExample { StudentId = 1004, Name = "Manish", Class = 9, Marks = 90.25 };
            StudentExample s2 = new StudentExample { StudentId = 1001, Name = "Scott", Class = 9, Marks = 89.90 };
            StudentExample s3 = new StudentExample { StudentId = 1005, Name = "Smith", Class = 9, Marks = 88.20 };
            StudentExample s4 = new StudentExample { StudentId = 1003, Name = "John", Class = 9 , Marks = 91.50 };
            List<StudentExample> students = new List<StudentExample>() { s1, s2, s3, s4 };

            students.Sort();
            foreach (StudentExample student in students)
            {
                Console.WriteLine(student.StudentId + " " + student.Name + " " + student.Class + " " + student.Marks);
            }
            Console.WriteLine();
            //to reverse
            Console.WriteLine("After Reverse");
            students.Reverse();
            foreach (StudentExample student in students)
            {
                Console.WriteLine(student.StudentId + " " + student.Name + " " + student.Class + " " + student.Marks);
            }
            Console.WriteLine();
            //Using the IComparer interface for comparing
            CompareStudent obj = new CompareStudent();
            Console.WriteLine("After sorting based on marks");
            students.Sort(obj);
            foreach (StudentExample student in students)
            {
                Console.WriteLine(student.StudentId + " " + student.Name + " " + student.Class + " " + student.Marks);
            }
            Console.WriteLine();
            Console.WriteLine("Compare the Names using Delegate Comparison and sort based on name");
            //Compare the Names using Delegate Comparison
            //create the object of comparison delegate
            Comparison<StudentExample> obj1 = new Comparison<StudentExample>(CompareNames);
            students.Sort(obj1);
            foreach (StudentExample student in students)
            {
                Console.WriteLine(student.StudentId + " " + student.Name + " " + student.Class + " " + student.Marks);
            }
            Console.ReadLine();
        }
    }
}
    