namespace recursion
{
    internal class Program
    {
        // factorial
        // 4! = 4 * 3 * 2 * 1 = 24
        static void Main(string[] args)
        {
            /*  Console.WriteLine("Enter number to recive factorial : ");
              int x = int.Parse(Console.ReadLine()); // Console.ReadLine() reads the input as a string. 
              // int.Parse() converts the input string to an integer.
              int y = factorial(x);
              Console.WriteLine(y);
            */
            /* Console.WriteLine(AddNumbers( 5, 4 ));
             Console.WriteLine(AddNumbers( 5.5 , 4.5 ));
             Console.WriteLine(AddNumbers(5 , 4 , 11));
            */
            int x = 30;
            int y = 40; 
            int sum = x + y;
            Console.WriteLine("sum : " , sum);
        }
        public static int AddNumbers(int x , int y)
        {
            int result = x + y;
            return result;
        }
        public static double AddNumbers(double x, double y)
        {
            double result = x + y;
            return result;
           // return (int)result; // casting if method type is integer or you can declare result in another method its typr is double 
        }
        public static int AddNumbers(int x, int y , int z)
        {
            int result = x + y + z ;
            return result;
        }
        public static int factorial(int x)
        {
            // base case 
            if (x < 0 )
            {
                Console.WriteLine("Erorr");
                return 0; // must exsist to avoid infinite loop 
            }
            
         else if (x == 0) {
                return 1;  // to avoid Stack overflow 
            }
            int result = x * factorial(x-1); // recursion 
            return result;
        }
        
    }
}
