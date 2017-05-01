using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TrainSolution4_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int mark = 0, i = 1; ;          //กำหนด ค่าเริ่มต้น ของตัวแปร
            Dice dic1 = new Dice();     // สร้าง อินสแตนด์ dic1 สำหรับสุ่มตัวเลขการโยนลูกเต๋า
            while (mark != 1)           //ให้วนจนกว่าการโยนลูกเต๋าจะได้เลขไม่เท่ากับ 1 (ค่าเริ่มต้น 0 )
            {                   // หลังจากการวนรอบจะได้ค่า 1- 6 ถ้าได้เลข 1 จะหยุดวนรอบ
                mark = dic1.Throw();        //เก็บค่าการโยนลูกเต๋าไว้ในตัวแปร mark
                Console.WriteLine(" {0} Mark of Dice : {1} ", i, mark); //แสดงจำนวนครั้ง (i) และแต้ม(mark)
                System.Threading.Thread.Sleep(10);  // หน่วงเวลาไว้เพื่อไม่ให้แต้มซ้ำกันในขณะสุ่มตัวเลข
                i = i + 1;                  // เพิ่มจำนวนครั้งที่โยนลูกเต๋า
            }
            Console.WriteLine("Throw of dice = 1 is : " + (i - 1) + " time "); //สรุปการโยนลูกเต๋าให้เท่ากับ 1 ว่ากี่ครั้ง
            Console.ReadLine();
        }
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
