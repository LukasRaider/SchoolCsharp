using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prvni3
{
    class Person
    {                        //
        public int age;                    //
    }                                    //
    class Employee : Person
    {          //
        public int salary;                   //
    }                                    //
    class Student : Person
    {              //
        public int scholarship;             //
        public Student(int vek, int stipendium)
        {
            this.age = vek; scholarship = stipendium;
        }
        public void writeInfo()
        {
            Console.WriteLine($"věk studenta: {age}, scholarship: {scholarship}");
        }
    }
    class Accountant : Employee
    {       //
        public Accountant(int vek, int plat)
        {
            age = vek; salary = plat;
        }
        public void writeInfo()
        {
            Console.WriteLine($"věk ekonomky: {age}, salary: {salary}");
        }
    }
    class Teacher : Employee
    {         //
        public int teachingTime;                 //
        public Teacher(int vek, int plat, int uvazek)
        {
            teachingTime = uvazek;
            salary = plat;
            age = vek;
        }
        public void writeInfo()
        {
            Console.Write($"věk učitele:  {age}, salary: {salary}");
            Console.WriteLine($", počet úvazkových hodin: {teachingTime}");
        }
    }
    class Prvni3
    {
        public static void Mainx()
        {
            Student s1 = new Student(20, 1000);
            s1.writeInfo();
            Accountant e1 = new Accountant(30, 12000);
            e1.writeInfo();
            Teacher u1 = new Teacher(40, 20000, 22);
            u1.writeInfo();
            Student s2 = new Student(19, 2000);
        }
    }
}
