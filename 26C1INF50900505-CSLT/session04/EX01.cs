
namespace _26C1INF50900505_CSLT.session04
{
    internal class EX01
    {
        public static void Main2(string[] args)
        {
            /*double d = 3.0 / 0.0;
            double d2 = 0.0 / 0.0;
            Console.WriteLine(d);
            Console.WriteLine(d2);

            int y = 0;
            int x = 4 / y;
            Console.WriteLine(x);*/
            checked
            {
                byte age = 250;
                age += 100;
                Console.WriteLine(age);

                int a = int.MaxValue;
                a += 100;
                Console.WriteLine(a);
            }

        }
    }
}
