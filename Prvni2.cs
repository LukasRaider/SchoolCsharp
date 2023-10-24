using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prvni2;
class Student
{
    public int age, scholarship;
    public Student(int vek, int stipendium)
    { //
        this.age = vek;                         //
        this.scholarship = stipendium;          //
    }
    public void writeInfo()
    {
        Console.WriteLine($"věk studenta: {age}, scholarship: {scholarship}");
    }
}
class Accountant
{
    public int age, salary;
    public Accountant(int vek, int plat)
    {
        age = vek;
        salary = plat;
    }
    public void writeInfo()
    {
        Console.WriteLine($"věk ekonomky: {age}, salary: {salary}");
    }
}
class Teacher
{
    public int age, salary, teachingTime;
    public Teacher(int vek, int plat, int uvazek)
    {
        salary = plat;
        age = vek;
        teachingTime = uvazek;
    }
    public void writeInfo()
    {
        Console.Write($"věk učitele:  {age}, salary: {salary}");
        Console.WriteLine($", počet úvazkových hodin: {teachingTime}");
    }
}
class Prvni2
{
    public static void Mainx()
    {
        Student s1 = new Student(20, 1000);   //
        s1.writeInfo();
        Accountant e1 = new Accountant(30, 12000);  //
        e1.writeInfo();
        Teacher u1 = new Teacher(40, 20000, 22);    //
        u1.writeInfo();

    }
}

