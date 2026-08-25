using System;
using System.Collections.Generic;
using System.Text;

namespace _26C1INF50900505_CSLT.session03
{
    internal class ex01
    {
        public static void Main(string[] args)
        {
            /*char a ='a';
            char A = 'A';
            Console.WriteLine(a+" - "+ (int)a);
            Console.WriteLine(A+ "- "+ (int)A);
            Console.WriteLine("Teo says: \"Hey!\"");

            Console.WriteLine(@"he \/\/\/");
            int az = 100;
            Console.WriteLine($"Gia tri a ={az}");//interpolation
*/
            /*checked
            {
                int num = 100;
                long l = 347534786874367l;
                int n2 = (int)l;
                Console.WriteLine(n2);
            }*/

            /*string s = "325763252";
            long l = long.Parse(s);
            l = l + 10;
            Console.WriteLine(l);
            
            //double d = double.Parse(s);
            double d = Convert.ToDouble(l);*/

            //yêu cầu
            //Nhập 1 số nằm trong khoảng 1-10
            /*Console.Write("Nhap 1 so tu 1 den 10: ");
            int so =int.Parse(Console.ReadLine());*/

            do
            {
                int so;
                Console.Write("Nhap 1 so tu 1 den 10: ");
                string ss = Console.ReadLine();
                bool ketqua = int.TryParse(ss, out so);
            
                if (ketqua == true && so >= 0 && so <= 10)
                {
                    Console.WriteLine(so);
                    break;
                }
                else
                {
                    Console.WriteLine("Ban nhap sai roi!");
                }
            } while (true);
            

        }
    }
}
