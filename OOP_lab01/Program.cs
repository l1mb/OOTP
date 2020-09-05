using System;

namespace OOP_lab01
{
    class Program
    {
        static void Main(string[] args)
        {
            dynamic basicTheory = new basicTheory();
            basicTheory.fivth();
            /*
             Первое задание 
              Когда любой значимый тип присваивается к ссылочному типу данных, значение перемещается из области стека в кучу. 
              Эта операция называется упаковкой.
              Когда любой ссылочный тип присваивается к значимому типу данных, значение перемещается из области кучи в стек. 
              Это называется распаковкой.
            
            int i = 7, j;
            object o = i;
            j = (int)o; 
            */

            int i = 7;
            long l = i;
            float f = i;
            double d = i;

            char c = (char)i;
            byte s = (byte)i;
            ushort us = (ushort)i;


            string name = Console.ReadLine();
            Console.WriteLine("{0}", name);                 //
            Console.WriteLine($"My name is {name}");        //Интерполяция


            Point point = new Point();
            point.x = 3;
            Console.WriteLine($"{point.GetType()}\n{point.Equals(point)}\n{Object.Equals(point, point)}");

            Console.WriteLine(point.x);


            string FirstString = "world", SecondString = "Hello ";

            SecondString = SecondString.Insert(6, FirstString);
            bool cont = SecondString.Contains(FirstString);
            SecondString = SecondString.Substring(6);
            SecondString = SecondString.Replace("world", "world");
            int tm = string.Compare(FirstString, SecondString);

            FirstString = "1";
            SecondString = null;

            if (String.IsNullOrWhiteSpace(FirstString) && String.IsNullOrWhiteSpace(SecondString))// как .IsNullOrEmpty, только проверяет содержит ли строка несколько пробелов
                Console.WriteLine("Строки пусты или их нет");
            else
                Console.WriteLine("{0}\n{1}", FirstString, SecondString);


            //var variable = -5;
            //variable = "";

            int? b = null;
            if (b.HasValue)
                Console.WriteLine($"b = {b.Value}");
            else
            {
                int dd = b ?? -1;
                Console.WriteLine($"d = {dd}");  // вывод: d = -1
            }

            //Средний уровень

            (int, int) temp = (228, 1488);
            var (first, second) = (1, 2);


            Console.WriteLine(tupleExample(temp));

            /*
            var t = (Sum: 4.5, Count: 3);
            Console.WriteLine($"Sum of {t.Count} elements is {t.Sum}.");

            (double Sum, int Count) d = (4.5, 3);
            Console.WriteLine($"Sum of {d.Count} elements is {d.Sum}.");

            var sum = 4.5;
var count = 3;
var t = (sum, count);
Console.WriteLine($"Sum of {t.count} elements is {t.sum}.");


            var a = 1;
var t = (a, b: 2, 3);
Console.WriteLine($"The 1st element is {t.Item1} (same as {t.a}).");
Console.WriteLine($"The 2nd element is {t.Item2} (same as {t.b}).");
Console.WriteLine($"The 3rd element is {t.Item3}.");
/

            деконструкция кортежей
            var t = ("post office", 3.6);
(string destination, double distance) = t;
Console.WriteLine($"Distance to {destination} is {distance} kilometers.");

            var t = ("post office", 3.6);
var (destination, distance) = t;
Console.WriteLine($"Distance to {destination} is {distance} kilometers.");
// Output:
// Distance to post office is 3.6 kilometer

            var destination = string.Empty;
var distance = 0.0;

var t = ("post office", 3.6);
(destination, distance) = t;
Console.WriteLine($"Distance to {destination} is {distance} kilometers.");
// Output:
// Distance to post office is 3.6 kilometers.

 */

            MiddleLevel theLuppa = new MiddleLevel();
            theLuppa.CheckTest();
           
            theLuppa.UnCheckTest();
        }

        class Point
        {
            public int x, y;
        }

        private static int tupleExample((int, int) qwe)
        {
            return qwe.Item1 * qwe.Item2;
        }

        class MiddleLevel
        {
            public void CheckTest()
            {
                byte q = 255, w;
                try
                    {
                        checked
                    {
                        Console.WriteLine((byte)(q++) + " It works");
                        }
                    }
                    catch(OverflowException)
                    {
                        Console.WriteLine($"{q} - Переполнение") ;
                    }
                
            }
            public void UnCheckTest()
            {
                byte q = 255, w;
                try
                {
                    unchecked
                    {
                        Console.WriteLine((byte)(q++)+ " It works");
                    }
                }
                catch (OverflowException)
                {
                    Console.WriteLine($"{q} - Переполнение");
                }

            }

        }
        class basicTheory
        {
            public void fivth()
            {
                Console.WriteLine("Введите переменные:\n");


                byte bVar = byte.Parse(Console.ReadLine());
                int iVar = int.Parse(Console.ReadLine());       //recommended input is 7;
                uint uiVar = uint.Parse(Console.ReadLine());
                short sVar = short.Parse(Console.ReadLine());
                string strVar = Console.ReadLine();


                Console.WriteLine("Ваши переменные:" +
                    $"\n{bVar.GetType()}\t{bVar}" +
                    $"\n{iVar.GetType()}\t{iVar}" +
                    $"\n{uiVar.GetType()}\t{uiVar}" +
                    $"\n{sVar.GetType()}\t{sVar}" +
                    $"\n{strVar.GetType()}\t{strVar}");

            }
        }

    }
}
