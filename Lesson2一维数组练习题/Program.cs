namespace Lesson2一维数组练习题
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[] a = new int[100];
            //for (int i = 0; i < a.Length; i++)
            //{
            //    a[i] = i;
            //    Console.WriteLine(a[i]);
            //}

            //Console.WriteLine("*******************************");
            //int[] b = new int[100];
            //for (int i = 0; i < b.Length; i++)
            //{
            //    b[i] = a[i] * 2;
            //    Console.WriteLine(b[i]);
            //}

            //Console.WriteLine("*******************************");
            //int[] c = new int[10];
            //Random r = new Random();
            //for (int i = 0; i < c.Length; i++)
            //{
            //    c[i] = r.Next(101);
            //    Console.WriteLine(c[i]);
            //}

            //Console.WriteLine("*******************************");
            //int[] d = new int[3];
            //Random ra = new Random();
            //int sum = 0, max = d[0], min = d[0];
            //for (int i = 0; i < d.Length; i++)
            //{
            //    d[i] = ra.Next(1, 101);
            //    sum += d[i];
            //    if (d[i] > max)
            //    {
            //        max = d[i];
            //    }
            //    if (d[i] < min)
            //    {
            //        min = d[i];
            //    }
            //}
            //Console.WriteLine("最大值为{0}", max);
            //Console.WriteLine("最小值为{0}", min);
            //Console.WriteLine("总和为{0}", sum);
            //Console.WriteLine("平均值为{0}", sum / d.Length);

            Console.WriteLine("*******************************");
            int[] ar = new int[6];
            for (int i = 0; i < ar.Length; i++)
            {
                ar[i] = i;
                Console.WriteLine(ar[i]);
            }
            //交换 那就中间商不赚差价 
            //int temp = ar[0];
            //ar[0] = ar[ar.Length - 1];
            //ar[ar.Length - 1] = temp;

            //temp = ar[1];
            //ar[1] = ar[ar.Length - 1 - 1];
            //ar[ar.Length - 1 - 1] = temp;

            //temp = ar[2];
            //ar[2] = ar[ar.Length - 1 - 2];
            //ar[ar.Length - 1 - 2] = temp;
            for (int i = 0; i < ar.Length / 2; i++)
            {
                int temp = ar[i];
                ar[i] = ar[ar.Length - 1 - i];
                ar[ar.Length - 1 - i] = temp;
            }
            for (int i = 0; i < ar.Length; i++)
            {
                Console.WriteLine(ar[i]);
            }

            Console.WriteLine("*******************************");
            int[] array = { -1, 0, 1 };
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0)
                {
                    array[i] -= 1;
                }
                else if (array[i] > 0)
                {
                    array[i] += 1;
                }
                Console.WriteLine(array[i]);
            }

            Console.WriteLine("*******************************");
            //int[] score = new int[10];
            //int max = 0;
            //int min = 0;
            //int sum = 0;
            //for (int i = 0; i < score.Length; i++)
            //{
            //    while (true)
            //    {
            //        try
            //        {
            //            Console.WriteLine("请输入成绩");
            //            score[i] = int.Parse(Console.ReadLine());
            //            break;
            //        }
            //        catch
            //        {
            //            Console.WriteLine("请输入正确数字");
            //        }
            //    }
            //    if (i == 0)
            //    {
            //        max = score[i];
            //        min = score[i];
            //    }
            //    else
            //    {
            //        if (score[i] > max)
            //        {
            //            max = score[i];
            //        }
            //        if (score[i] < min)
            //        {
            //            min = score[i];
            //        }
            //    }
            //    sum += score[i];
            //}
            //Console.WriteLine("最高分为{0}", max);
            //Console.WriteLine("最低分为{0}", min);
            //Console.WriteLine("平均成绩为{0}", sum / score.Length);

            Console.WriteLine("*******************************");
            string[] str = new string[25];
            for (int i = 0; i < str.Length; i++)
            {
                str[i] = i % 2 == 0 ? "■" : "□";
                if (i % 5 == 0 && i != 0)
                {
                    Console.WriteLine();
                }
                Console.Write(str[i]);
            }
        }

    }

}
