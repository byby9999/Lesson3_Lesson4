using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3_Lesson4
{
    //Demo functii - cu parametri, cu tip de return, cu parametri optionali, cu parametri numiti
    public class Lesson4
    {
        public static void Run() 
        {
            Console.WriteLine("Hello World!");

            Console.WriteLine("Here is my branch!");

            int[] numere = new int[] { 1, 8, 13, 21, 37, 41, 74, 12, 4, 3, 10, 101, 3423 };
            double[] preturi = new double[] { 13, 5, 1.5, 39, 100 };

            Console.WriteLine(numere.Length);
            Console.WriteLine(numere.Rank);

            Console.WriteLine("Numerele castigatoare sunt:----------------------------------------");

            DisplayArray(numere);

            Array.Sort(numere);

            Console.WriteLine("Array-ul dupa sortare este:");

            DisplayArray(numere);

            for (int i = 0; i < preturi.Length; i++)
            {
                preturi[i] *= 0.9;
            }

            Console.WriteLine("Preturile reduse sunt:");

            DisplayArray(preturi);

            string[,] tabla = new string[3, 3] {
                { "X", "0", "X" },
                { "X", "0", "X" },
                { "0", "X", "0" } };

            if (tabla[0, 0] == tabla[1, 1] && tabla[1, 1] == tabla[2, 2])
            {
                Console.WriteLine("Castigatorul este: " + tabla[0, 0]);
            }

            for (int r = 0; r < tabla.GetLength(0); r++)
            {
                string row = "";
                for (int c = 0; c < tabla.GetLength(1); c++)
                {
                    row += " " + tabla[r, c];
                }
                Console.WriteLine(row);
            }

            //Sortare, cautare, comparare
            string[] names = new string[] { "Alex", "Ionut", "Dorin", "Bianca" };

            Console.WriteLine("Inainte de sortare:");

            DisplayArray(names);

            Array.Sort(names);

            Console.WriteLine("Dupa sortare:");

            DisplayArray(names);

            int[] Numbers = new int[] { 12, 3, 5, 7, 9 };
            int[] Numbers2 = new int[] { 1, 3, 5, 7, 9 };

            int five = Array.Find(Numbers, number => number == 5);
            int greaterThan7 = Array.Find(Numbers, number => number > 5);

            Console.WriteLine("Find 5: " + five);
            Console.WriteLine("Greater than 7: " + greaterThan7);

            bool areEqual = Numbers.SequenceEqual(Numbers2);
            if (areEqual == true)
            {
                Console.WriteLine("Numberss = Numbers2");
            }
            else
            {
                Console.WriteLine("Numbers NU e egal cu Numbers2");
            }

            double[] temperaturi = new double[10] { 13, 12, 10, 8, 9, 11, 19, 20, 15, 12 };

            double[] first2 = temperaturi.Take<double>(2).ToArray();

            Console.WriteLine("Prognoza urmatoarele 2 zile:");

            DisplayArray(first2);

            Console.WriteLine("Temperatura medie urmatoarele 10 zile: " + temperaturi.Average());

            Console.WriteLine("Temperatura MAXIMA: " + temperaturi.Max());
            Console.WriteLine("Temperatura MINIMA: " + temperaturi.Min());

            if (temperaturi.Contains(20))
            {
                Console.WriteLine("Va fi o zi calda in urmatoarele 10 zile");
            }

            if (temperaturi.Any(x => x > 20))
            {
                Console.WriteLine("Exista minimum o zi foarte calda");
            }

            if (temperaturi.All(x => x >= 8))
            {
                Console.WriteLine("Toate zilele vor avea cel putin 8 grade");
            }

            Console.WriteLine("Suma gradelor pe urmatoarele 10 zile: " + temperaturi.Sum());

            double[] peste10 = temperaturi.Where(x => x > 10).ToArray();

            Console.WriteLine("Temperaturi peste 10:");

            DisplayArray(peste10);

            int ct = temperaturi.Count(x => x > 10);
            Console.WriteLine(ct + " din urmatoarele 10 zile au temperaturi peste 10");

            Console.WriteLine(Add(65, 12));
            int result = Add(23, 6);

            result = result + 10;

            Console.WriteLine(result);

            string repeat = RepeatString("Invat C#", 3);
            Console.WriteLine(repeat);

            repeat = RepeatString("Buna", 10);
            Console.WriteLine(repeat);

            repeat = RepeatString("Hello");
            Console.WriteLine(repeat);

            Console.WriteLine("-------------------Hotel");

            CheckInGuest("Popescu Ion", 2, true);
            CheckInGuest("Petrescu Maria", 3, false);
            CheckInGuest("Popa Ana", 4);

            string numeGuest = "Georgescu Ioana";
            int nopti = 5;
            bool micDejun = true;

            CheckInGuest(nrNights: 3, name: "Petre Popescu", wantsBreakfast: false);

            CheckInGuest(wantsBreakfast: micDejun, name: numeGuest, nrNights: nopti);

            double aria = AriaCerc(2);
            Console.WriteLine(aria);

            aria = AriaCerc(4);

            int X = 2, Y = 3;
            Console.WriteLine($"Inainte: x = {X} y = {Y}");
            
            Inversare(ref X, ref Y);
            
            Console.WriteLine($"Dupa: x = {X} y = {Y}");

            int[] myNumbers = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            Console.WriteLine("PARE:");
            DisplayArrayPare(myNumbers);

            Console.WriteLine("IMPARE:");
            DisplayArrayImpare(myNumbers);

            Console.WriteLine("TOATE:");
            DisplayArray(myNumbers);

        }

        static void DisplayArray(int[] array) 
        {
            for (int index = 0; index < array.Length; index++)
            {
                Console.WriteLine(array[index]);
            }
        }

        static void DisplayArray(double[] array)
        {
            for (int index = 0; index < array.Length; index++)
            {
                Console.WriteLine(array[index]);
            }
        }
        static void DisplayArray(string[] array)
        {
            for (int index = 0; index < array.Length; index++)
            {
                Console.WriteLine(array[index]);
            }
        }

        static int Add(int a, int b) 
        {
            return a + b;
        }

        static string RepeatString(string mesaj, int nr = 2) 
        {
            string result = "";
            for(int i = 0; i < nr; i++) 
            {
                result += mesaj;
            }
            return result;
        }

        static void CheckInGuest(string name, int nrNights, bool wantsBreakfast = false) 
        {
            Console.WriteLine($"Am cazat urmatorul turist: {name}, pt. {nrNights} nopti, mic dejun inclus: {wantsBreakfast}");
        }

        static double AriaCerc(double raza) 
        {
            double pi = 3.14;

            return pi * raza * raza;
        }

        static void Inversare(ref int x, ref int y) 
        {
            int temp = x;
            x = y;
            y = temp;
        }

        static void DisplayArrayPare(int[] numbers) 
        {
            for(int i = 0; i< numbers.Length; i++) 
            {
                if (numbers[i] % 2 == 0) 
                {
                    Console.WriteLine(numbers[i]);
                }  
            }
        }
        static void DisplayArrayImpare(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 1)
                {
                    Console.WriteLine(numbers[i]);
                }
            }
        }
    }
}
