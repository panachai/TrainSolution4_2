using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TrainSolution4_2
{
    class Program
    {

        public Program()
        {

        }

        static void Main(string[] args)
        {
            Console.WriteLine("Choose type Dice\nEnter 1 = 'OneDice' Enter 2 = 'SnakeEye'");
            Int32 readData = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();

            int mark, mark2, i;
            Dice dic1;

            i = 1;
            mark = 0;
            mark2 = 0;
            dic1 = new Dice();

            if (readData == 1)
            {

                //OneDice();
                while (mark != 1)
                {
                    mark = dic1.Throw();
                    Console.WriteLine(" {0} Mark of Dice : {1} ", i, mark);
                    System.Threading.Thread.Sleep(10);
                    i = i + 1;
                }
                Console.WriteLine("Throw of dice = 1 is : " + (i - 1) + " time ");
                Console.ReadLine();
            }
            else if (readData == 2)
            {
                //SnakeEye();
                while (mark != 1 || mark2 != 1)
                {
                    mark = dic1.Throw();
                    mark2 = dic1.Throw();
                    Console.WriteLine(" {0} Mark of Dice 1 : {1} ", i, mark);
                    Console.WriteLine(" {0} Mark of Dice 2 : {1} ", i, mark2);
                    System.Threading.Thread.Sleep(10);
                    i = i + 1;
                }
                Console.WriteLine("Throw of dice = 1 is : " + (i - 1) + " time ");
                Console.ReadLine();
            }
        }
        /*
        public  void OneDice()
        {
            
            //i = 1;
           // mark = 0;
           // mark2 = 0;
           // dic1 = new Dice();
            

            while (mark != 1)
            {
                mark = dic1.Throw();
                Console.WriteLine(" {0} Mark of Dice : {1} ", i, mark);
                System.Threading.Thread.Sleep(10);
                i = i + 1;
            }
            Console.WriteLine("Throw of dice = 1 is : " + (i - 1) + " time ");
            Console.ReadLine();

        }

        public  void SnakeEye()
        {
           
            //i = 1;
            //mark = 0;
            //mark2 = 0;
            //dic1 = new Dice();
            

            while (mark != 1 || mark2 != 1)
            {
                mark = dic1.Throw();
                mark2 = dic1.Throw();
                Console.WriteLine(" {0} Mark of Dice 1 : {1} ", i, mark);
                Console.WriteLine(" {0} Mark of Dice 2 : {1} ", i, mark2);
                System.Threading.Thread.Sleep(10);
                i = i + 1;
            }
            Console.WriteLine("Throw of dice = 1 is : " + (i - 1) + " time ");
            Console.ReadLine();
        }
        */

    }
    class Dice
    {
        Random random = new Random();
        int[] resultDice = new[] { 1, 2, 3, 4, 5, 6 };

        internal int Throw()
        {
            //throw new NotImplementedException();
            int valueRandom = random.Next(0, resultDice.Length) + 1;
            //Console.WriteLine(valueRandom);
            return valueRandom;
        }
    }
}
