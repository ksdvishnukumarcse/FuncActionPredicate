using System;

namespace FuncActionPredicate
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executing Func Delegate");
            Func<string, string, bool> funcDelegate = new Func<string, string, bool>(IsMatchString);
            var funcResult = funcDelegate.Invoke("string", "string");
            Console.WriteLine($"Both string is Equal ? {funcResult}");
            Console.WriteLine();

            Console.WriteLine("Executing Func Action");
            Action<string, string> actionDelegate = new Action<string, string>(MatchString);
            actionDelegate.Invoke("string", "string");
            Console.WriteLine();

            Console.WriteLine("Executing Predicate Delegate");
            Predicate<int> predicateDelegate = new Predicate<int>(IsEvenNumber);
            var predicateResult= predicateDelegate.Invoke(2);
            Console.WriteLine($"The given number is Even Number ? {predicateResult}");

            Console.ReadLine();
        }

        private static bool IsMatchString(string s1, string s2)
        {
            return s1.Equals(s2);
        }

        private static void MatchString(string s1, string s2)
        {
            var result = s1.Equals(s2) ? "equal" : "not equal";
            Console.WriteLine($"Both strings are {result}");
        }

        private static bool IsEvenNumber(int a)
        {
            return a % 2 == 0;
        }
    }
}
