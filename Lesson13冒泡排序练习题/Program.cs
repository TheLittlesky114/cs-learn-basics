namespace Lesson13冒泡排序练习题
{
    struct Sort
    {
        public int[] array;
        bool isSort;
        int temp;
        public Sort(int[] array)
        {
            this.array = array;
            isSort = false;
            temp = 0;
        }
        public int[] ascend()
        {
            for (int m = 0; m < array.Length; m++)
            {
                isSort = false;
                for (int n = 0; n < array.Length - 1 - m; n++)
                {
                    if (array[n] > array[n + 1])
                    {
                        isSort = true;
                        temp = array[n];
                        array[n] = array[n + 1];
                        array[n + 1] = temp;
                    }
                }
                if (!isSort)
                {
                    break;
                }
            }
            return array;
        }
        public int[] descend()
        {
            for (int m = 0; m < array.Length; m++)
            {
                isSort = false;
                for (int n = 0; n < array.Length - 1 - m; n++)
                {
                    if (array[n] < array[n + 1])
                    {
                        isSort = true;
                        temp = array[n];
                        array[n] = array[n + 1];
                        array[n + 1] = temp;
                    }
                }
                if (!isSort)
                {
                    break;
                }
            }
            return array;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[20];
            Random r = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = r.Next(101);
                Console.WriteLine(arr[i]);
            }
            Console.WriteLine("*************************");
            int temp = 0;
            bool isSort = false;
            for (int m = 0; m < arr.Length; m++)
            {
                isSort = false;
                for (int n = 0; n < arr.Length - 1 - m; n++)
                {
                    if (arr[n] > arr[n + 1])
                    {
                        isSort = true;
                        temp = arr[n];
                        arr[n] = arr[n + 1];
                        arr[n + 1] = temp;
                    }
                }
                if (!isSort)
                {
                    break;
                }
            }
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
            Console.WriteLine("*************************");
            for (int m = 0; m < arr.Length; m++)
            {
                isSort = false;
                for (int n = 0; n < arr.Length - 1 - m; n++)
                {
                    if (arr[n] < arr[n + 1])
                    {
                        isSort = true;
                        temp = arr[n];
                        arr[n] = arr[n + 1];
                        arr[n + 1] = temp;
                    }
                }
                if (!isSort)
                {
                    break;
                }
            }
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }

            Console.WriteLine("*************************");
            Console.WriteLine("*************************");
            int[] ints = new int[5];
            for (int i = 0; i < ints.Length; i++)
            {
                ints[i] = r.Next(101);
                Console.WriteLine(ints[i]);
            }
            Console.WriteLine("*************************");
            Sort sort = new Sort(ints);
            for (int i = 0; i < sort.ascend().Length; i++)
            {
                Console.WriteLine(sort.ascend()[i]);
            }
            Console.WriteLine("*************************");
            for (int i = 0; i < sort.descend().Length; i++)
            {
                Console.WriteLine(sort.descend()[i]);
            }
        }
    }
}
