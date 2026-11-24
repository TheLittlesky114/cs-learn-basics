namespace Lesson3二维数组练习题
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[,] array = new int[100, 100];
            //int a = 1;
            //for (int i = 0; i < array.GetLength(0); i++)
            //{
            //    for (int j = 0; j < array.GetLength(1); j++)
            //    {
            //        array[i, j] = a++;
            //        Console.Write(array[i, j] + " ");
            //    }
            //    Console.WriteLine();
            //}

            Console.WriteLine("********************");
            int[,] array1 = new int[4, 4];
            Random r = new Random();
            for (int i = 0; i < array1.GetLength(0); i++)
            {
                for (int j = 0; j < array1.GetLength(1); j++)
                {
                    if (j > 1 && i <= 1)
                    {
                        array1[i, j] = 0;
                    }
                    else
                    {
                        array1[i, j] = r.Next(1, 101);
                    }

                    Console.Write(array1[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("********************");
            int[,] array2 = new int[3, 3];
            int sum = 0;
            for (int i = 0; i < array2.GetLength(0); i++)
            {
                for (int j = 0; j < array2.GetLength(1); j++)
                {
                    array2[i, j] = r.Next(1, 11);
                    //对角线 元素 满足的条件
                    if (i == j || i + j == 2)
                    {
                        sum += array2[i, j];
                    }
                }
            }
            Console.WriteLine(sum);

            Console.WriteLine("********************");
            int[,] array3 = new int[5, 5];
            int maxI = 0, maxJ = 0;
            for (int i = 0; i < array3.GetLength(0); i++)
            {
                for (int j = 0; j < array3.GetLength(1); j++)
                {
                    array3[i, j] = r.Next(1, 501);
                    Console.Write(array3[i, j] + " ");
                    //找最大值
                    if (array3[i, j] > array3[maxI,maxJ])
                    {
                        maxI = i;
                        maxJ = j;
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine("最大值：" + array3[maxI,maxJ]);
            Console.WriteLine("行列号：" + maxI + "  " + maxJ);

            Console.WriteLine("********************");
            int[,] array4 = { { 0, 0, 0, 0, 0 },
                              { 0, 0, 0, 0, 0 },
                              { 0, 1, 0, 0, 0 },
                              { 0, 0, 1, 1, 0 },
                              { 0, 0, 0, 0, 0 } };
            bool[] hang = new bool[5];
            bool[] lie = new bool[5];
            for (int i = 0; i < array4.GetLength(0); i++)
            {
                for (int j = 0; j < array4.GetLength(1); j++)
                {
                    if (array4[i, j] == 1)
                    {
                        //记录了 当前 行列 是否要变1的标识
                        //要变1 就置true
                        hang[i] = true;
                        lie[j] = true;
                    }
                }
            }
            for (int i = 0; i < array4.GetLength(0); i++)
            {
                for (int j = 0; j < array4.GetLength(1); j++)
                {
                    if (hang[i] || lie[j])
                    {
                        //满足行和列的标识 是true 就变1
                        array4[i, j] = 1;
                    }
                    Console.Write(array4[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
