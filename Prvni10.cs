using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prvni10;

abstract class Person
{                                         //
    public int age;
    private static int count = 0;
    public Person() { count++; }
    public Person(int vek)
    {
        age = vek; count++;
    }
    public abstract void writeInfo();                 //{
    //  Console.Write("počet osob: " + count + ", věk:  " + age);//
    //}                                                          //
    public static int getCount()
    {
        return count;
    }
}
abstract class Employee : Person
{
    public int salary;
    public Employee() { }
    public Employee(int vek, int plat)
      : base(vek)
    {
        salary = plat;
    }

    public override void writeInfo()
    {
        //  base.writeInfo();                                                  //
        Console.Write($"počet osob: {Person.getCount()}, věk:  {age}"); //
        Console.Write($", salary: {salary}");
    }
}
class Student : Person
{
    public int scholarship;
    //public Student() { }
    public Student(int vek, int stipendium)
      : base(vek)
    {
        scholarship = stipendium;
    }
    public override void writeInfo()
    {
        //  base.writeInfo();                                                   //
        Console.Write($"počet osob: {Person.getCount()}, věk:  {age}");  //
        Console.WriteLine($", scholarship: {scholarship}");
    }
}
class Accountant : Employee
{
    public Accountant(int vek, int plat)
      : base(vek, plat)
    {
    }
    public override void writeInfo()
    {
        base.writeInfo();
        Console.WriteLine();
    }
}
class Teacher : Employee
{
    public int teachingTime;
    public Teacher(int vek, int plat, int uvazek)
      : base(vek, plat)
    {
        teachingTime = uvazek;
    }
    public override void writeInfo()
    {
        base.writeInfo();
        Console.WriteLine($", počet úvazkových hodin: {teachingTime}");
    }
}
class Prvni10
{
    public static void Mainx()
    {
        Student s1 = new Student(20, 1000);
        s1.writeInfo();
        Accountant e1 = new Accountant(30, 12000);
        e1.writeInfo();
        Teacher u1 = new Teacher(40, 20000, 22);
        u1.writeInfo();
        Console.WriteLine($"Celkový počet osob: {Person.getCount()}, věk osoby u1:  {u1.age}");
    }
}
