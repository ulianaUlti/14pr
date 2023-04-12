using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;


namespace Practica_14
{
    class Stack
    {
        static void Main(string[] args)
        {
            Stack<int> intStack = new Stack<int>();

            Console.WriteLine("Введите число элементов");
            int num = int.Parse(Console.ReadLine());


            if (num < 1)
                    Console.WriteLine("Введи от 1 до нужного числа");
           else
            {
                    
                    Console.WriteLine("n: "+ num );
                for (int i = 0; i < num; i++)
                {
                    intStack.Push(i);
                }

                Console.WriteLine("Размерность стека: " + intStack.Count());
                Console.WriteLine("Верхний элемент стека: " + intStack.Peek());
                Console.WriteLine("Содержимое стека: " );
                while (intStack.Count != 0)
                {
                    Console.WriteLine("{0}", intStack.Pop());
                    Console.WriteLine("Новая размерность стека " + intStack.Count());

                }

                    //Console.Write("Новая рамерность стека: " +0);
            }




            //foreach (var numb in num)
            //    Console.WriteLine(numb);

            Console.WriteLine("Введите математическое выражение");
            string math =Convert.ToString(Console.ReadLine());
         
            StreamWriter t = File.AppendText("Math.txt");
      

            t.Close();
            string t2 = File.ReadAllText("Math.txt");
            string[]mas=t2.Split(new char[] {'),') ) },StringSplitOptions.Remo

        }



    }
}
