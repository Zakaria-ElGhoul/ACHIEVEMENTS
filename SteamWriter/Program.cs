using System;
using System.IO;

namespace Streamwriter
{
    class Program
    {

        static void Main(string[] args)
        {

            Console.WriteLine("Type textbestand");
            WriteToFile(Console.ReadLine());
            
            

        }
    

        static private void WriteToFile(string text)
        {
        
          
            Console.WriteLine("Textbestand aangemaakt");
           
            StreamWriter SW = new StreamWriter(@"Word.doc");
            SW.WriteLine(text);
            SW.Close();
        }

    }
}