namespace TestMaximum
{
    class Program
    {
        public static void Main(String[] args)
        {

            testCases<int> test = new testCases<int>();

            Console.WriteLine("Given Max Number at 1st Position from {5,4,3} return the Same Number : Test Case 1 ");
            Console.WriteLine(test.maxi(5, 4, 3));
            Console.WriteLine("Given Max Number at 2nd Position from {55,88,73} return the Same Number : Test Case 2 ");
            Console.WriteLine(test.maxi(45, 99, 65));
            Console.WriteLine("Given Max Number at 3rd Position from {101,447,833} return the Same Number : Test Case 3 ");
            Console.WriteLine(test.maxi(101, 447, 833));
        }
    }
}