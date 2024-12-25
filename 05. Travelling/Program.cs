namespace _05._Travelling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string destination = Console.ReadLine();
            double price;
            double money;
            double savings;

            while (destination != "End") 
            { 
                price = double.Parse(Console.ReadLine());
                savings = 0;
               
                while (savings < price)
                {
                    money = double.Parse(Console.ReadLine());
                    savings += money;
                    
                }
                Console.WriteLine($"Going to {destination}!");
                destination = Console.ReadLine();
               


            }
            return;
           
        }
    }
}
