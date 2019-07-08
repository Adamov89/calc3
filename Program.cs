using System;

namespace calc4
{
    public interface IMath
    {
        void Algorithm();
    }
    public class Multiplication : IMath
    {
        public void Algorithm()
        {
            Console.WriteLine("нажмите *");
        }
    }

    public class Division : IMath
    {
        public void Algorithm()
        {
            Console.WriteLine("нажмите /");
        }
    }

    public class Adding : IMath
    {
        public void Algorithm()
        {
            Console.WriteLine("нажмите +");
        }
    }

    public class Minus : IMath
    {
        public void Algorithm()
        {
            Console.WriteLine("нажмите -");
        }
    }

    public class Context
    {
        private IMath _math;
        public Context(IMath math)
        {
            _math = math;
        }
        public void SetStrategy(IMath math)
        {
            _math = math;
        }

        public void ExecuteOperation()
        {
            _math.Algorithm();
        }

    }



    public static class Program
    {
        public static void Main()
        {
            Context context = new Context(new Multiplication());
            context.ExecuteOperation();

            context.SetStrategy(new Division());
            context.ExecuteOperation();

            context.SetStrategy(new Adding());
            context.ExecuteOperation();

            context.SetStrategy(new Minus());
            context.ExecuteOperation();
        }

    }
}