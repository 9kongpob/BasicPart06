using System;

namespace BasicPart06_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            string nameA = "kong";
            string nameB = "Jojo";
            string nameC = "Num";
            string[] name = {nameA,nameB,nameC };

            Console.WriteLine("Check nameA : " + nameA);
            Console.WriteLine("Check nameB : " + nameB);
            Console.WriteLine("Check nameC : " + nameC);
            Console.WriteLine("Check name.Length : " + name.Length);

            int count = 0;
            foreach (string i in name)
            {
                Console.WriteLine("Check Array[" + count + "] : " + i);
                count++;
            }
            /*for (int i = 0; i < name.Length; i++)
            {
                Console.WriteLine("Check Array["+i+"] : " + name[i]);
            }*/

            Console.ReadKey();
        }
    }
}
