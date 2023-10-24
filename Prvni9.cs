using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prvni9;
class Person
{
    private int age;                   //
    protected static int count;                // když není public, tak je automaticky private
    public Person() { count++; }
    public Person(int vek)
    {
        age = vek; count++;
    }
    public virtual void writeInfo()
    {
        Console.Write($"počet osob: {count}, věk:  {age}");
    }
    public static int getCount()
    {        //
        return count;                       //
    }                                     //
    public int getAge()
    {                 //
        return age;                         //
    }                                     //
    public void setAge(int age)
    {         //
        this.age = age;                     //
    }                                     //
}
class Employee : Person
{

    //public int salary;                    //3
    //public int salary { set; get; }         //3
    public int Salary { get; set; }

    public Employee() { }
    public Employee(int vek, int plat)
        : base(vek)
    {
        //salary = plat;                         //3
        Salary = plat;      //3
    }
    public override void writeInfo()
    {
        base.writeInfo();
        //Console.Write(", salary: " + salary); //3
        Console.Write($", salary: {Salary}");   //3
                                                //Console.Write(", počet osob2: " + count);   //nelze. Zde private atribut potřebuje getter
        Console.Write($", počet osob2: {count}"); // zde protected atribut nepotřebuje getter
        Console.Write($", věk:  {getAge()}");
    }
}
class Student : Person
{
    private int scholarship;

    //public Student() { }                 //
    public Student(int vek, int stipendium)
      : base(vek)
    {
        Scholarship = stipendium;
    }

    public int Scholarship { get => scholarship; set => scholarship = value; }

    //init vlastnost - lze ji změnit jen v konstruktoru (nové od C# 9)

    public override void writeInfo()
    {
        base.writeInfo();
        Console.WriteLine($", scholarship: {Scholarship}");  //
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
    private int teachingTime;                           //2
                                                        //int teachingTime;                                    //2

    //int teachingTime;                                    //2
    public int TeachingTime
    {
        get
        {
            return teachingTime;
        }
        set
        {
            if (value > 40)
            {
                Console.WriteLine("Uvazek nesmi byt vic nez 40 hodin");
            }
            else
            {
                teachingTime = value;
            }
        }
    }

    public Teacher(int vek, int plat, int uvazek)
      : base(vek, plat)
    {
        TeachingTime = uvazek;                                  //2  kompilovat by šlo i teachingTime = uvazek;  ale to by v konstruktoru prošel i úvazek > 40 hodin
    }



    public override void writeInfo()
    {
        base.writeInfo();
        Console.WriteLine($", počet úvazkových hodin: {TeachingTime}");
    }
}
class Prvni9
{
    public static void Mainx()
    {
        Student s1 = new Student(20, 1000);
        s1.writeInfo();
        Accountant e1 = new Accountant(30, 12000);
        e1.writeInfo();
        Teacher u1 = new Teacher(40, 20000, 42);
        u1.writeInfo();
        Console.WriteLine($"počet osob: {Person.getCount()}, věk:  {u1.getAge()}"); //zde musí být oba gettery
        Console.WriteLine(u1.TeachingTime);      //2
        Console.WriteLine(u1.Salary);        //3
                                             //Student s2 = new Student();             //
                                             //s2.writeInfo();                           //
                                             //Console.WriteLine("počet osob: " + Person.count + ", scholarship:  " + s1.scholarship);  //
    }
}
