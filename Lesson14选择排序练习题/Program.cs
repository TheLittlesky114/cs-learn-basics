namespace Lesson14选择排序练习题
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[20];
            Random r = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = r.Next(101);
                Console.Write(arr[i] + " ");
            }
            
            Console.WriteLine();
            int index = 0, temp = 0;
            for (int m = 0; m < arr.Length; m++)
            {
                index = 0;
                for (int n = 1; n < arr.Length - m; n++)
                {
                    if (arr[index] < arr[n])
                    {
                        index = n;
                    }
                }
                if (index != arr.Length - 1 - m)
                {
                    temp = arr[index];
                    arr[index] = arr[arr.Length - 1 - m];
                    arr[arr.Length - 1 - m] = temp;
                }
            }
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }

            Console.WriteLine();
            for (int m = 0; m < arr.Length; m++)
            {
                index = 0;
                for (int n = 1; n < arr.Length - m; n++)
                {
                    if (arr[index] > arr[n]) 
                    {
                        index = n;
                    }
                }
                if (index != arr.Length - 1 - m)
                {
                    temp = arr[index];
                    arr[index] = arr[arr.Length - 1 - m];
                    arr[arr.Length - 1 - m] = temp;
                }
            }
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }
    }
}
