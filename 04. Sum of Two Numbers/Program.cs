namespace _04._Sum_of_Two_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            int magicNumber = int.Parse(Console.ReadLine());
            int count = 0;
            bool flag = false;

            for (int i = start; i <= end; i++)
            {
                for (int j = start; j <= end; j++)
                {
                    count++;
                    if (i + j == magicNumber)
                    {
                        flag = true;
                        Console.WriteLine($"Combination N:{count} ({i} + {j} = {magicNumber})");
                        break;

                    }


                }
                if (flag)
                {
                    break;
                }
            }
            if (flag == false)
            {
                Console.WriteLine($"{count} combinations - neither equals {magicNumber}");
            }
        }
    }
}
