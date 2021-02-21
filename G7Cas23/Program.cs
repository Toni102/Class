using System;
using System.Collections.Generic;
using Rajak;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Car Yugo = new Car("Zastava", "55");

            Yugo.Color = "white";

            Console.WriteLine("Yugo is {0}.", Yugo.Color);
            Console.WriteLine("Yugo is manufactured by {0}", Yugo.Manufacturer);
            Console.WriteLine("Yugo model is {0}", Yugo.Model);
            CarEngine engine = Yugo.Engine;
            Console.WriteLine("Yugo has a {0} HP engine, model {1}", engine.Power, engine.Name);

            Yugo.Drive();

            Mathematics Math = new Mathematics();

            List<int> nums = new List<int>();
            nums.Add(1);
            nums.Add(9);
            Console.WriteLine("Sum = {0}", Mathematics.Sum(nums));
            Console.WriteLine("Add = {0}", Math.Add(1, 9));

            double n1 = 5, n2 = 0;
            string oper;
            
            oper = "+";
            Console.WriteLine("[SimpleCalc] {0} {1} {2} = {3}", n1, oper, n2, SimpleCalc.Calc(oper, n1, n2));
            oper = "-";
            Console.WriteLine("[SimpleCalc] {0} {1} {2} = {3}", n1, oper, n2, SimpleCalc.Calc(oper, n1, n2));
            oper = "*";
            Console.WriteLine("[SimpleCalc] {0} {1} {2} = {3}", n1, oper, n2, SimpleCalc.Calc(oper, n1, n2));
            oper = "/";
            Console.WriteLine("[SimpleCalc] {0} {1} {2} = {3}", n1, oper, n2, SimpleCalc.Calc(oper, n1, n2));

            Console.ReadKey();
        }
    }
}
