using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace сегодня
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //задание1
            //Console.Write("a= ");
            //int a = int.Parse(Console.ReadLine());
            //Console.Write("b= ");
            //int b = int.Parse(Console.ReadLine());
            //Console.WriteLine($"{a} + {b} = {a + b}\n{a} * {b} = {a * b}");
            //Console.ReadLine();

            //задание2
            //Console.Write("a= ");
            //int a = int.Parse(Console.ReadLine());
            //Console.Write("b= ");
            //int b = int.Parse(Console.ReadLine());
            //Console.WriteLine($"{a} + {b} = {b} + {a}\n{a} * {b} = {b} * {a}");
            //Console.ReadLine();

            //задание3
            //Console.Write("a= ");
            //int a = int.Parse(Console.ReadLine());
            //Console.Write("b= ");
            //int b = int.Parse(Console.ReadLine());
            //Console.Write("c= ");
            //int c = int.Parse(Console.ReadLine());
            //Console.WriteLine($"{a} + {b} + {c} = {b + a + c}");
            //Console.ReadLine();

            //задание4
            //Console.Write("a= ");
            //double a = Convert.ToDouble(Console.ReadLine());
            //Console.Write("b= ");
            //double b = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine($"{a:F1} * {b:F1} = {a * b :F1}");
            //Console.ReadLine();

            //задание5
            //Console.Write("a= ");
            //double a = Convert.ToDouble(Console.ReadLine());
            //Console.Write("b= ");
            //double b = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine($"{a:F3} / {b:F3} = {a / b:F3}");
            //Console.ReadLine();

            //задание6
            //Console.Write("a = "); 
            //double a = Convert.ToDouble(Console.ReadLine());
            //Console.Write("b = ");
            //double b = Convert.ToDouble(Console.ReadLine());
            //Console.Write("c = ");
            //double c = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine($"({a:F2} | {b:F2}) | {c:F2} = {a:F2} | ({a:F2} | {c:F2})");
            //Console.ReadLine();

            //задание7
            //Console.Write("a= ");
            //int a = Convert.ToInt32(Console.ReadLine());
            //Console.Write("b= ");
            //int b = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine($"{a} + {b} = {a + b}\t{a} - {b} = {a - b}\t{a} * {b} = {a * b} ");
            //Console.ReadLine();

            //задание8
            //Console.Write("Номинал купюры: ");
            //int a = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Количество купюр: ");
            //int b = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine($"Сумма денег = {a * b:F2}р.");
            //Console.ReadLine();







            //задание1
            Console.Write("R=");
            double R = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"L={2 * Math.PI * R:F2}\nS={Math.PI * Math.Pow(R, 2):F2}");
            Console.ReadLine();

            //задание2
            //Console.Write("Количество жителей: ");
            //int j = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Площадь территории (км^2): ");
            //double t = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine($"{j / t:F0} чел/км^2");
            //Console.ReadLine();

            //задание3
            //Console.Write("a= ");
            //double a = Convert.ToDouble(Console.ReadLine());
            //Console.Write("b= ");
            //double b = Convert.ToDouble(Console.ReadLine());
            //// Находим гипотенузу
            //double c = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));
            //double p = a + b + c;
            //Console.WriteLine($"P= {p}");
            //Console.ReadLine();

            //задание4
            //Console.Write("a= ");
            //double a = Convert.ToDouble(Console.ReadLine());
            //Console.Write("b= ");
            //double b = Convert.ToDouble(Console.ReadLine());
            //double p = 2 * (a + b);
            //double d = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));
            //Console.WriteLine($"P= {p}\nD= {d:F1}");
            //Console.ReadLine();

            //задание5
            //Console.Write("X1= ");
            //double x1 = Convert.ToDouble(Console.ReadLine());
            //Console.Write("Y1= ");
            //double y1 = Convert.ToDouble(Console.ReadLine());
            //Console.Write("X2= ");
            //double x2 = Convert.ToDouble(Console.ReadLine());
            //Console.Write("Y2= ");
            //double y2 = Convert.ToDouble(Console.ReadLine());
            //double D = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            //Console.WriteLine($"D= {D:F1}");
            //Console.ReadLine();

            //задание6
            //Console.Write("Cтоимость 1 кг конфет: ");
            //double k = Convert.ToDouble(Console.ReadLine());
            //Console.Write("Cтоимость 1 кг печенья: ");
            //double p = Convert.ToDouble(Console.ReadLine());
            //Console.Write("Cтоимость 1 кг яблок: ");
            //double a = Convert.ToDouble(Console.ReadLine());
            //Console.Write("Сколько кг конфет: ");
            //double k2 = Convert.ToDouble(Console.ReadLine());
            //Console.Write("Сколько кг печенья: ");
            //double p2 = Convert.ToDouble(Console.ReadLine());
            //Console.Write("Сколько кг яблок: ");
            //double a2 = Convert.ToDouble(Console.ReadLine());
            //double x = (k * k2) + (p * p2) + (a * a2);
            //Console.WriteLine($"Общая стоимость: {x:F2} руб.");
            //Console.ReadLine();

            //задание7
            //Console.Write("Введите двузначное число: ");
            //int x = Convert.ToInt32(Console.ReadLine());

            //int d = (x / 10) % 10; // Число десятков
            //int e = x % 10; // Число единиц

            //int s = d + e; // Сумма цифр
            //int p = d * e; // Произведение цифр

            //Console.WriteLine($"Число десятков: {d}");
            //Console.WriteLine($"Число единиц: {e}");
            //Console.WriteLine($"Сумма цифр: {s}");
            //Console.WriteLine($"Произведение цифр: {p}");
            //Console.ReadLine();
        }
    }
}
