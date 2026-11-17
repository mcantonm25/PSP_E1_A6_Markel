using System;
using System.Threading;

namespace PSP_E1_A6_Markel
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // 1. galdera:
            Console.WriteLine("1. GALDERA:");
            Thread haria1_Ane = new Thread(Atazak1_Ane);
            Thread haria1_Borja = new Thread(Atazak1_Borja);
            Thread haria1_Jon = new Thread(Atazak1_Jon);

            haria1_Ane.Start();
            haria1_Borja.Start();
            haria1_Jon.Start();

            haria1_Ane.Join();
            haria1_Borja.Join();
            haria1_Jon.Join();

            // 2. galdera:
            Console.WriteLine("\n2. GALDERA:");
            Thread haria2_1 = new Thread(() => Atazak2_Batuketa(3,5));
            Thread haria2_2 = new Thread(() => Atazak2_Biderketa(4,6));
            Thread haria2_3 = new Thread(() => Atazak2_Batuketa(7,8));

            haria2_1.Start();
            haria2_2.Start();
            haria2_3.Start();

            haria2_1.Join();
            haria2_2.Join();
            haria2_3.Join();

            // 3. galdera:
            Console.WriteLine("\n3. GALDERA:");
            Thread haria3_1 = new Thread(() => Atazak2_Batuketa(3, 5));
            Thread haria3_2 = new Thread(() => Atazak2_Biderketa(4, 6));
            Thread haria3_3 = new Thread(() => Atazak2_Batuketa(7, 8));

            haria3_1.Start();
            haria3_1.Join();

            haria3_2.Start();
            haria3_2.Join();

            haria3_3.Start();
            haria3_3.Join();

            // 4. galdera:
            Console.WriteLine("\n4. GALDERA:");
            Thread haria4_1 = new Thread(() => Atazak2_Batuketa(3, 5));
            Thread haria4_2 = new Thread(() => Atazak2_Biderketa(4, 6));
            Thread haria4_3 = new Thread(() => Atazak2_Batuketa(7, 8));

            haria4_1.Start();
            haria4_2.Start();

            haria4_1.Join();
            haria4_2.Join();

            haria4_3.Start();
            haria4_3.Join();
        }

        // 1. galdera:
        private static void Atazak1_Ane()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Ane");
                Thread.Sleep(300);
            }
            Console.WriteLine("Ane haria bukatu da.");
        }

        private static void Atazak1_Borja()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Borja");
                Thread.Sleep(900);
            }
            Console.WriteLine("Borja haria bukatu da.");
        }

        private static void Atazak1_Jon()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Jon");
                Thread.Sleep(500);
            }
            Console.WriteLine("Jon haria bukatu da.");
        }

        // 2, 3 eta 4. galdera:
        private static void Atazak2_Batuketa(int zbk1, int zbk2)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Batuketaren emaitza: "+(zbk1+zbk2));
                Thread.Sleep(300);
            }
            Console.WriteLine("Haria amaituta - Batuketa "+zbk1+" + "+zbk2+" = "+(zbk1 + zbk2));
        }

        private static void Atazak2_Biderketa(int zbk1, int zbk2)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Biderketaren emaitza: "+(zbk1*zbk2));
                Thread.Sleep(1000);
            }
            Console.WriteLine("Haria amaituta - Biderketa "+zbk1+" * "+zbk2+" = "+(zbk1*zbk2));
        }
    }
}