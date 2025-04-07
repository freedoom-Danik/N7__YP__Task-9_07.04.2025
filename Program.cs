namespace N7__YP__Task_9_07._04._2025
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("input n: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++) 
            {
                string spaces = new string(' ', i);
                string stars = new string('*', 2 * (n - i) - 1);
                Console.WriteLine(spaces + stars);

            }
        }
    }
}
