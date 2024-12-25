namespace _06._Building
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int floors = int.Parse(Console.ReadLine());
            int appartments = int.Parse(Console.ReadLine());

            for (int i = floors; i >= 1; i--)
            {
                for (int j = 0; j < appartments; j++)
                {
                    if (i == floors)
                    { 
                        Console.Write($"L{i}{j} ");
                        
                    }
                    else if (i % 2 == 0 )
                    {
                        Console.Write($"O{i}{j} ");
                       
                    }
                    else if (i % 2 != 0)
                    {
                        Console.Write($"A{i}{j} ");
                    }

                }
                Console.WriteLine();
            }


        }
    }
}
