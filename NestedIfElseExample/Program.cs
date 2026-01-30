namespace NestedIfElseExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program starts");
            Console.WriteLine("We are working on nested if else");
            //In if Condition if we use another if condition then it is called nestedif else
            Console.WriteLine("Value1 : ");
            int value1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Value2 : ");
            int value2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Value3 : ");
            int value3 = int.Parse(Console.ReadLine());
            if (value1 > value2)
            {
                if (value1 > value3)
                {
                    Console.WriteLine($"{value1} is the largest no.");
                }
                else
                {
                    Console.WriteLine($"{value3} is the largest no.");
                }
            }
            else
            {
                if (value2 > value3)
                {
                    Console.WriteLine($"{value2} is the largest no.");
                }
                else
                {
                    Console.WriteLine($"{value3} is the largest no.");
                }
            }
            Console.WriteLine("program stops");
            Console.ReadLine();
        }
    }
}
