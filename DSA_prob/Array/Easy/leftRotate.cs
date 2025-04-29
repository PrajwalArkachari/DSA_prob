
//namespace DSA_prob.Array.Easy
//{
//    internal class leftRotate
//    {
//        static void Main(string[] args)
//        {
//            int n = int.Parse(Console.ReadLine());
//            int[] arr = new int[n];
//            for (int i = 0; i < n; i++) arr[i] = int.Parse(Console.ReadLine());
//            Console.WriteLine("Enter the number of rotations");
//            int k = int.Parse(Console.ReadLine());
//            for (int i = 0; i < n; i++) Console.Write(arr[i] + " ");
//            Console.WriteLine();
//            kRotations(arr, k);
//            for (int i = 0; i < n; i++) Console.Write(arr[i] + " ");

//        }
//        static void kRotations(int[] arr, int k)
//        {
//            int n = arr.Length;
//            k = k % n;
//            reverse(arr, 0, n - k - 1);
//            reverse(arr, n - k, n - 1);
//            reverse(arr, 0, n - 1);
//        }
//        static void reverse(int[] arr, int low, int high)
//        {
//            while (low < high)
//            {
//                int temp = arr[low];
//                arr[low] = arr[high];
//                arr[high] = temp;
//                low++; high--;
//            }
//        }
//    }
//}
