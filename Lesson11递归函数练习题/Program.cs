namespace Lesson11递归函数练习题
{
    internal class Program
    {
        static void Fun(int a)
        {
            if (a > 10)
            {
                return;
            }
            Console.WriteLine(a);
            ++a;
            Fun(a);
        }

        static int Fun1(int a)
        {
            if (a <= 1)
            {
                return 1;
            }
            return a * Fun1(a - 1);
        }

        static int Fun2(int a)
        {
            if (a <= 1)
            {
                return Fun1(1);
            }
            return Fun1(a) + Fun2(a - 1);
        }

        static void Length(float a, int day = 0)
        {
            if (day > 10)
            {
                Console.WriteLine(a);
                return;
            }
            Length(a / 2, day + 1);
        }

        static bool Num(int a)
        {
            Console.WriteLine(a);
            return a == 200 || Num(a + 1);
        }

        static void Main(string[] args)
        {
            Fun(0);

            Console.WriteLine(Fun1(5));

            Console.WriteLine(Fun2(5));

            Length(100);

            Num(1);
        }
    }
}
