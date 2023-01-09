namespace TestMaximum
{
    class Program
    {
        public static void Main(String[] args)
        {
            testCases<int> test = new testCases<int>();

            Console.WriteLine("Given Max Number at 1st Position from {5,4,3} return the Same Number : Test Case 1 ");
            Console.WriteLine(test.max(5, 4, 3));
            Console.WriteLine("Given Max Number at 2nd Position from {55,99,65} return the Same Number : Test Case 2 ");
            Console.WriteLine(test.max(45, 99, 65));
            Console.WriteLine("Given Max Number at 3rd Position from {101,447,833} return the Same Number : Test Case 3 ");
            Console.WriteLine(test.max(101, 447, 833));
            Console.WriteLine("-----------------------------------");

            testCases<float> test1 = new testCases<float>();

            Console.WriteLine("Given Max Number at 1st Position from {5.5,4.4,3.73} return the Same Number:Test Case 1 ");
            Console.WriteLine(test1.max(5.5F, 4.4F, 3.3F));
            Console.WriteLine("Given Max Number at 2nd Position from {55.8,89.76,73.66} return the Same Number:Test Case 2 ");
            Console.WriteLine(test1.max(45.8F, 99.76F, 65.66F));
            Console.WriteLine("Given Max Number at 3rd Position from {101.56,447.01,833.09} return the Same Number:Test Case 3 ");
            Console.WriteLine(test1.max(101.56F, 434.01F, 703.09F));
            Console.WriteLine("-----------------------------------");

            testCases<string> test2 = new testCases<string>();

            Console.WriteLine("Given Max Number at 1st Position from {Peach\",\"Apple\", \"Banana}return the Same Number:Test Case 1 ");
            Console.WriteLine(test2.max("Peach", "Apple", "Banana"));
            Console.WriteLine("Given Max Number at 2nd Position from {angle\", \"volume\", \"shape} return the Same Number:Test Case 2 ");
            Console.WriteLine(test2.max("angle", "volume", "shape"));
            Console.WriteLine("Given Max Number at 3rd Position from {lawyer\", \"docter\", \"sofware\"} return the Same Number:Test Case 3 ");
            Console.WriteLine(test2.max("lawyer", "docter", "sofware"));
        }
    }
}