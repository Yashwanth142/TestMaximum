namespace TestMaximum
{
    class Program
    {
        public static void Main(String[] args)
        {

            testCases<string> test = new testCases<string>();

            Console.WriteLine("Given Max Number at 1st Position from {Peach\",\"Apple\", \"Banana}return the Same Number:Test Case 1 ");
            Console.WriteLine(test.maxi("Peach", "Apple", "Banana"));
            Console.WriteLine("Given Max Number at 2nd Position from {angle\", \"volume\", \"shape} return the Same Number:Test Case 2 ");
            Console.WriteLine(test.maxi("angle", "volume", "shape"));
            Console.WriteLine("Given Max Number at 3rd Position from {lawyer\", \"docter\", \"sofware\"} return the Same Number:Test Case 3 ");
            Console.WriteLine(test.maxi("lawyer","docter", "sofware"));
        }
    }
}