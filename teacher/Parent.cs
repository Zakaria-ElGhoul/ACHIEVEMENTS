using System;

namespace classAssignment
{
    public class Parent : Person
    {
        private string parentName;
        public Parent(string parentName, string name):base(name){
            this.parentName = parentName;
            Console.WriteLine("Mijn ouder heten: " + parentName);

        }
    public int leeftijd = 54;
    public Leef Day
    {
        get
        {
            // We don't allow this to be used on Friday.
            if (this.leeftijd == leeftijd)
            {
                throw new Exception("Invalid access");
            }
            return this.leeftijd;
        }
        set
        {
            this.leeftijd = value;
        }
    }
}}