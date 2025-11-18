namespace LeetCode_326
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an integer to check if it is a power of three:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(IsPowerOfThree(a) ? "是 3 的冪" : "不是 3 的冪");
        }

        static bool IsPowerOfThree(int n)
        {
            do
            {
                if (n <= 0)
                {
                    return false;
                }
                else if (n == 1)
                {
                    return true;
                }
                else if (n % 3 != 0)
                {
                    return false;
                }
                else
                {
                    n = n / 3;
                }
            } while (true);
        }
    }
}
