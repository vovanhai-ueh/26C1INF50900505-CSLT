using System;
using System.Collections.Generic;
using System.Text;

namespace _26C1INF50900505_CSLT.session03
{
    internal class Ex02
    {
        /// <summary>
        /// kelvin = celsius + 273
        // fahrenheit = celsius x 18 / 10 + 32
        /// </summary>
        static void ex01()
        {
            Console.Write("Nhập vào độ Celsius: ");
            float celsius = float.Parse(Console.ReadLine());//

            float kelvin = celsius + 273;
            float fahrenheit = celsius * 18 / 10 + 32;

            Console.WriteLine($"{celsius} °C = {kelvin} °K = {fahrenheit} °F");
        }

        /// <summary>
        /// surface= 4 * pi * radius squared
        // volume= 4 / 3 * pi* radius cubed
        /// </summary>
        static void ex02()
        {
            Console.Write("Nhập vào bán kính hình trụ tròn: ");
            float radius = float.Parse(Console.ReadLine());//

            double surface = 4 * Math.PI * Math.Pow(radius,2);
            double volume = 4 / 3 * Math.PI * Math.Pow(radius, 3);

            Console.WriteLine($"Sphere with radius ={radius} " +
                $"- surface = {surface:f3}, volume = {volume:f3}");
        }

        static void ex03()
        {

        }

        public static void Main1(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            //ex01();
            ex02();
            ex03();
        }
    }
}
