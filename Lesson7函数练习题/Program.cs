namespace Lesson7函数练习题
{
    internal class Program
    {
        static int Max(int a, int b)
        {
            //1
            //if (a > b)
            //{
            //    return a;
            //}
            //else
            //{
            //    return b;
            //}
            //2
            //if (a > b)
            //{
            //    return a;
            //}
            //return b;
            //3
            return a > b ? a : b;
        }

        static float[] Calc(float r)
        {
            //1
            //float[] f = new float[2];
            //f[0] = 3.14f * r * r;
            //f[1] = 3.14f * 2 * r;
            //return f;

            //2
            return new float[] { 3.14f * r * r, 3.14f * 2 * r };
        }

        static void Calcu(int[] arr)
        {
            if (arr.Length == 0)
            {
                Console.WriteLine("数组不能为空");
                return;
            }
            int sum = 0;
            int max = arr[0], min = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
                if (max < arr[i])
                {
                    max = arr[i];
                }
                if (min > arr[i])
                {
                    min = arr[i];
                }
            }
            Console.WriteLine("总和为：{0}，最大值为：{1}，最小值为{2}，平均值为{3}", sum, max, min, sum / arr.Length);
        }

        static bool IsPrime(int a)
        {
            for (int i = 2; i < a; i++)
            {
                if (a % i == 0)
                {
                    // 之前和循环配合使用 break continue
                    return false;
                }
            }
            //默认就认为它是质数
            return true;
        }

        static bool IsLeap(int year)
        {
            if (year % 400 == 0 || year % 4 == 0 && year % 100 != 0)
            {
                return true;
            }
            return false;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Max(1, 2));

            float[] f = Calc(2);
            Console.WriteLine("圆的面积是：" + f[0]);
            Console.WriteLine("圆的周长是：" + f[1]);

            Calcu(new int[] { 8, 10, 12 });

            Console.WriteLine("{0}{1}质数", 5, IsPrime(5) ? "是" : "不是");

            Console.WriteLine("{0}{1}闰年", 2000, IsLeap(2000) ? "是" : "不是");
        }
    }
}
