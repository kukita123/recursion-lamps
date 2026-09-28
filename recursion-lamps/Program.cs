namespace recursion_lamps
{
    internal class Program
    {
        private static long callCount = 0;
        private static int totalPaths = 0;
        static void FindPaths(int current, int target, string path)
    {
        if (current == target)
        {
            Console.WriteLine($"Път: {path}");
            totalPaths++;
            return;
        }

        if (current > target) return;

        // Скок с 1 камък
        FindPaths(current + 1, target, path + " -> " + (current + 1));

        // Скок с 2 камъка
        FindPaths(current + 2, target, path + " -> " + (current + 2));
    }
        static void Lamps(int[] a, int index)
        {
            if (index == a.Length)
            {
                Console.WriteLine(string.Join(" ", a));
                return;
            }

            a[index] = 0;
            Lamps(a, index + 1);

            a[index] = 1;
            Lamps(a, index + 1);
        }
        static long Fibonacci(int n)
        {
            callCount++; // Увеличаваме брояча при всяко влизане
            if (n <= 2) 
                return 1;
            return 
                Fibonacci(n - 1) + Fibonacci(n - 2);
        }
        static long Factorial(int n)
        {
            callCount++;
            if(n <= 2)
                return 1;
            return 
                n * Factorial (n - 1);
        }
        

        static void Main(string[] args)
        {
            #region Lamps
            ////recursion lamps
            //int n = 3;

            //int[] lamps = new int[n];

            //Lamps(lamps, 0);
            #endregion

            #region Fibonacci
            //Console.Write("Enter n for Fibonacci: ");
            //int n = int.Parse(Console.ReadLine());

            //callCount = 0;
            //long result = Fibonacci(n);

            //Console.WriteLine($"Fibonacci({n}) = {result}");
            //Console.WriteLine($"Recursive calls count: {callCount}");
            #endregion

            #region Factorial
            //Console.Write("Enter n for Factorial: ");
            //int n = int.Parse(Console.ReadLine());

            //callCount = 0;
            //long result = Factorial(n);

            //Console.WriteLine($"Factorial({n}) = {result}");
            //Console.WriteLine($"Recursive calls count: {callCount}");

            #endregion

            #region FrogPaths
            int targetStone = 5;
            Console.WriteLine($"Всички възможни скокове от камък 1 до камък {targetStone}:");
            FindPaths(1, targetStone, "1");
            Console.WriteLine($"Общ брой начини: {totalPaths}");

            #endregion

        }
    }
}
