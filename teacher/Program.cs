using System;

namespace classAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Teacher t1 = new Teacher("Erwin", "PRO2");
            Teacher t2 = new Teacher("Erik", "PRO2");
            Teacher t3 = new Teacher("Theo", "PRO1");
            Teacher t4 = new Teacher("Alex", "PRO2");

            Student s1 = new Student("Harry", "Mediadeveloper");
            Student s2 = new Student("Donny", "Gamedeveloper");
            Student s3 = new Student("Zakaria", "Gamedeveloper");

            Parent p1 = new Parent("Pa en Ma", "Joe");
            Parent p2 = new Parent("a", "Vandaag is het=");
            Parent = p2.leeftijd;
            Console.WriteLine(Parent == p2.leeftijd);

        }
    }
}