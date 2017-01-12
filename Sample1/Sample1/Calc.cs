using System;

namespace Sample1
{
    class Calc : ICalc
    {
        public double Add(int a, int b)
        {
            Console.WriteLine("add");
            return a + b;
        }
        public double Div(double a, double b)
        {
            return a / b;
        }
        public int DivB(int a, int b)
        {
            return a / b;
        }
        public int DivD(int a, int b)
        {
            return a / b;
        }

        public int DivByZero(int a)
        {
            return a / 0;
        }
        
        public int Mult(int a, int b)
        {
            return a * b;
        }
    }
}
