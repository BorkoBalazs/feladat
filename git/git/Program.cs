using System;

namespace git
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int szam =0 ;
            szam = int.Parse(Console.ReadLine());

            for (int i = 0; i < szam; i++)
            {
                Console.Write(i + ", ");
            }

        }
    }
}
