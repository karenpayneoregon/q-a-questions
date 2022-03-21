using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleDelegateEventAction.Classes
{
    public class ActionClass
    {
        public void InvokeLater(Action action)
        {
            action();
        }
        public void DoSomethingElse(int param1, string param2)
        {
            Debug.WriteLine($"Called in {nameof(DoSomethingElse)} Parameter1: {param1}\tParameter2 {param2}");
        }
        public void DoSomething(int parameter1, string parameter2)
        {
            Debug.WriteLine($"Called in {nameof(DoSomething)} Parameter1: {parameter1}\tParameter2 {parameter2}");
        }

        public delegate void SayAnything();
        public readonly SayHello HelloFunction = () => Debug.WriteLine("Hello!");
        public static readonly SayAnything HelloFunction2 = () => Debug.WriteLine("Hello!");
        public static readonly SayAnything GoodbyeFunction2 = () => Debug.WriteLine("Goodbye!");
        public static readonly Func<string, string, int> SumCharacters = (value1, value2) => value1.Length + value2.Length;
        public delegate void SayHello();
        public static readonly Action<string> GreetingsAction = (name) => Debug.WriteLine($"Hello {name}");
    }
}
