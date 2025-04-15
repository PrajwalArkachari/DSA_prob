public class Demo
{
    public static void Main(String[] args)
    {
        Console.WriteLine("Enter the number to count the digit");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("The number "+n+" has "+countDigit(n)+" digits");
        
    }

    public static int countDigit(int n)
    {
        int count = 0;
        while(n > 0)
        {
            count++;
            n = n / 10;
        }
        return count;
    }
}