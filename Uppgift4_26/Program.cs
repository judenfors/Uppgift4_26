using System;

namespace Uppgift4_26
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv ett heltal");
            string tal1 = Console.ReadLine();

            for(int i = 0; i < tal1.Length; i++)
            {
                string tecken1 = tal1[i].ToString();
                int siffra1 = int.Parse(tecken1);

                switch (siffra1)
                {
                    case 9:
                        siffra1 = 0;
                        break;
                    default:
                        siffra1++;
                        break;


                }
                Console.Write(siffra1);
            }
        }
    }
}