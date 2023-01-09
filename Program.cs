namespace TestMaximum
{
    class Program
    {
        public static void Main(String[] args)
        {

            testCases<int> test = new testCases<int>();

            Console.WriteLine("Enter three numbers: ");

            int a=Convert.ToInt32(Console.ReadLine());
            int b=Convert.ToInt32(Console.ReadLine());
            int c=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("The maximum of three number is : "+test.maxi(a,b,c));
        }
    }
}