using System;

namespace GenericProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TestClass test = new TestClass();
            int result = test.IntCompare(1, 2, 3);
            Console.WriteLine(result);
                
            TestClass2 test1 = new TestClass2();
            float result1 = test1.floatCompare(1.1f, 2.1f, 3.3f);
            Console.WriteLine(result1);
                     
            TestClass3 test2 = new TestClass3();
            string result2 = test2.StringCompare("1", "2", "3");
            Console.WriteLine(result2);
           
            TestClass4 test3 = new TestClass4();
            int result3 = test3.Compareall<int>(2, 1, 3);
            Console.WriteLine(result3);



            TestClass<string> test4 = new TestClass<string>("3", "4", "2");
            string result4 = test4.Compare("3", "4", "2");
            Console.WriteLine(result4);

        }
        }
    }

