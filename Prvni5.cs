using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prvni5;
class Person
{
    public int age;
    //public Person() { }         //implicitní konstruktor nyní nevyužíváme, ale měl by být v každé třídě být
    public Person(int vek)
    {
        age = vek;
    }
}
class Employee : Person
{
    public int salary;
    //public Employee() { }   //implicitní konstruktor nyní nevyužíváme, ale měl by v každé třídě být
    public Employee(int vek, int plat) : base(vek)
    {                //
        //age = vek; 
        salary = plat;
    }
}
class Student : Person
{
    public int scholarship;
    public Student(int vek, int stipendium) : base(vek)
    {                //
                     //age = vek;
        scholarship = stipendium;
    }
    public void writeInfo()
    {
        Console.WriteLine($"věk studenta: {age}, scholarship: {scholarship}");
    }
}
class Accountant : Employee
{
    public Accountant(int vek, int plat)
      : base(vek, plat)
    {             //
                  //age = vek;
                  //salary = plat;
    }
    public void writeInfo()
    {
        Console.WriteLine($"věk ekonomky: {age}, salary: {salary}");
    }
}
class Teacher : Employee
{
    public int teachingTime;
    public Teacher(int vek, int plat, int uvazek)
      : base(vek, plat)
    {             //
                  //age = vek;
                  //salary = plat;
        teachingTime = uvazek;
    }
    public void writeInfo()
    {
        Console.Write($"věk učitele:  {age}, salary: {salary}");
        Console.WriteLine($", počet úvazkových hodin: {teachingTime}");
    }
}
class Prvni5
{
    public static void Mainx()
    {
        //Console.Title = "Prvni 5";
        Student s1 = new Student(20, 1000);
        s1.writeInfo();
        Accountant e1 = new Accountant(30, 12000);
        e1.writeInfo();
        Teacher u1 = new Teacher(40, 20000, 22);
        u1.writeInfo();
    }
}
