using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrays_all
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Gegeben ist folgendes Array { 1, -2, -25 , 6 , -3 , 5 , -4  , -9 , 11 }
            //(1) Geben Sie zunächst das Array in der Konsole aus und
            //(2)	Geben Sie die Anzahl der Elemente im Array aus
            //(3) Bestimmen Sie die Anzahl der negativen Elemente und geben Sie die Anzahl ebenfalls in der Konsole aus
            //(4) Erstellen Sie ein zweites Array.Die Größe des Arrays entspricht der Anzahl der negativen Zahlen.
            //Speichern in diesem Array die negativen Zahlen und geben Sie das neue Array aus.

            int[] zahlen = { 2, 4, 6 };
            Console.WriteLine("Inhalt Array");
            foreach (int i in zahlen)
            {
                Console.WriteLine(i);
            }
            zahlen[2] = zahlen[0] * zahlen[1];
            Console.WriteLine("Inhalt Array neu");
            foreach (int i in zahlen)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();

            int[] zahl = { 1, -2, -25, 6, -3, 5 };
            Console.WriteLine("Inhalt Array");
            foreach (int k in zahl)
            {
                Console.Write(" " + k);
            }
            Console.WriteLine("\n\nIm Array sind folgende negativen zahlen");
            for (int i = 0; i < zahl.Length; i++)

            {
                if (zahl[i] < 0)
                {
                    Console.Write(" " + zahl[i]);
                }
            }
            int count = 0;
            for (int i = 0; i < zahl.Length; i++)

            {
                if (zahl[i] < 0)
                {
                    count++;
                }
            }
            Console.WriteLine("\nNúmero de negativos:" + count);

            //  Console.ReadLine();

            int[] zahl = { 1, -2, -25, 6, -3, 5, -4, -9, 11 };

            Console.WriteLine("Inhalt Array");
            foreach (int k in zahl)
            {
                Console.Write(" " + k);
            }

            int anzahl = zahl.Length;


            Console.WriteLine("\nAnzahl:" + anzahl);

            Console.WriteLine("\n\nDas Array rückwärts");
            Array.Reverse(zahl);
            foreach (int k in zahl)

            {
                Console.Write(k + "\t");
            }
            Console.WriteLine("\n\nDas Array geordnet");
            Array.Sort(zahl);
            foreach (int k in zahl)
            {
                Console.Write(k + "\t");
            }

            Console.WriteLine("\n\nSumme der Zahlen im Array bestimmen");
            int sum = zahl.Sum();
            Console.WriteLine("Die Summe des Arrays ist: " + sum);

            Console.WriteLine("\nDie größte Zahl im Array bestimmen");
            int max = zahl.Max();
            Console.WriteLine("Die größte zahl des Arrays ist: " + max);

            Console.WriteLine("\nDie kleinste Zahl im Array bestimmen");
            int min = zahl.Min();
            Console.WriteLine("Die kleinste zahl des Arrays ist: " + min);


            Console.WriteLine("\n Die Negativen Zahlen;");

            for (int k = 0; k < anzahl; k++)
            {
                if (zahl[k] < 0)
                {
                    Console.WriteLine(" " + zahl[k]);
                }
            }
            int i, j = 0, negativzahl;
            for (i = 0; i < zahl.Length; i++)

            {
                if (zahl[i] < 0)
                { j++; }
            }
            negativzahl = j;
            Console.WriteLine("Es gibt  {0} negative zahlen", negativzahl);
            j = 0;
            int[] negativarray = new int[negativzahl];
            for (i = 0; i < zahl.Length; i++)
            {
                if (zahl[i] < 0)
                {
                    negativarray[j] = zahl[i]; j++;
                }
            }
            for (j = 0; j < negativzahl; j++)
            {
                Console.Write("     " + negativarray[j]);

            }





            Console.WriteLine();
            Console.ReadLine();

        }
    }
}
