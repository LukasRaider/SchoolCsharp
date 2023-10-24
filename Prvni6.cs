using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prvni6;
class Person
{
    public int age;
    public Person() { }
    public Person(int vek)
    {
        age = vek;
    }
    public void writeInfo()
    {      //
        Console.Write($"věk:  {age}"); //
    }                            //
}
class Employee : Person
{
    public int salary;
    public Employee(int vek, int plat)
      : base(vek)
    {
        salary = plat;
    }
    public void writeInfo()
    {      //
        base.writeInfo();            //pokud neuvedeme base., pak rekurzivní volání sebe sama, přeteče zásobník
        Console.Write($", salary: {salary}"); //        
    }
}
class Student : Person
{
    public int scholarship;
    public Student(int vek, int stipendium)
      : base(vek)
    {                //
        scholarship = stipendium;            //
    }
    public void writeInfo()
    {
        base.writeInfo();            //pokud neuvedeme base., pak rekurze
        Console.WriteLine($", scholarship: {scholarship}");//
    }
}
class Accountant : Employee
{
    public Accountant(int vek, int plat)
      : base(vek, plat)
    {             //
    }
    public void writeInfo()
    {
        base.writeInfo();            //
        Console.WriteLine();       //
    }
}
class Teacher : Employee
{
    public int teachingTime;
    public Teacher(int vek, int plat, int uvazek)
      : base(vek, plat)
    {             //
        teachingTime = uvazek;	               //
    }
    public void writeInfo()
    {
        base.writeInfo();            //
        Console.WriteLine($", počet úvazkových hodin: {teachingTime}");
    }
}
class Prvni6
{
    public static void Mainx()
    {
        Student s1 = new Student(20, 1000);
        s1.writeInfo();
        Accountant e1 = new Accountant(30, 12000);
        e1.writeInfo();
        Teacher u1 = new Teacher(40, 20000, 22);
        u1.writeInfo();
    }
}
