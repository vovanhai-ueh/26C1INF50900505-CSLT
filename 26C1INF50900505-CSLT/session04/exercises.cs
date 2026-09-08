namespace _26C1INF50900505_CSLT.session04
{
    internal class exercises
    {
        public static void Main1(string[] args)
        {
            ex6();
        }

        /// <summary>
        ///  takes a character as 
        ///  input and checks if it is a vowel, a digit, or any other symbol.
        /// </summary>
        static void ex6()
        {
            Console.Write("Nhap vao 1 ky tu: ");
            char c = Console.ReadLine()[0];
            //Console.WriteLine(c);

            int ascii_of_a = (int)c;
            Console.WriteLine(ascii_of_a);

            if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u')
            {
                Console.WriteLine("la nguyen am");
            }
            else if (c >= 97 && c <= 122)
            {
                Console.WriteLine("la phu am");
            }
            else if (ascii_of_a >= 48 && ascii_of_a <= 57)
            {
                Console.WriteLine("La so");
            }
            else
            {
                Console.WriteLine("other symbol");
            }
            /*bool kq = c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u';
            Console.WriteLine(kq==true?"nguyen am":"khong phai nguyen am");*/

        }
    }
}
