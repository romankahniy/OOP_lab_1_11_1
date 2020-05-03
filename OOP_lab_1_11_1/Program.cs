using System;

namespace OOP_lab_1_11_1
{
    public class Program
    {
        public static int Main()
        {
            int A = 4;
            int B = 5;
            int C = 6;

            Console.WriteLine("А = {0}, B = {1},  C = {2}", A, B, C);

            int tempInt = A;
            A = C;
            C = B;
            B = tempInt;

            Console.WriteLine("\nА = {0}, B = {1},  C = {2}", A, B, C);

            return A * 100 + B * 10 + C;
        }
    }
}
