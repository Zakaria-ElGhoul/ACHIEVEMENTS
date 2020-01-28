using System;

namespace Command
{
    class Program
    {
        static void Main(string[] args)
        {

            // Write to console window.



             Console.WriteLine("hoe groot moeten de getallen van de array zijn");
             string getal = Console.ReadLine();



             Console.WriteLine("tot welk getal moet het willekeurige getallen gaan.");
             string willekeurige = Console.ReadLine();


             int getallengte = Convert.ToInt32(getal);
             int getalwillekeurig = Convert.ToInt32(willekeurige);

             int[] Parameter(int getalLengte, int getalwillekeurig)
             {

                int[] NumberLijst = new int[getallengte];

                Random Rnd = new Random();
                for(int i = 0; i < getalLengte; i++)
                {
                    NumberLijst[i] = Rnd.Next(0, getalwillekeurig);
                    //Console.WriteLine(NumberLijst[m]);
                }

                return NumberLijst;
            }

             int[] bla = Parameter( getallengte, getalwillekeurig);

             foreach (int getalletje in bla)
             {
                 Console.WriteLine(getalletje);
             }







        }
    }
}
