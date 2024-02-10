//Console.WriteLine("Hello, OS");

namespace InterfaceImplementsType
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("OS");

            InterfaceImplement interfaceImplement = new InterfaceImplement();
            //Using this obj we can call the Add method directly because
            //It is implemented using public access specifier
            interfaceImplement.Add(40, 40);
            //interfaceImplement.Sub(80, 40); //will give compiler error
            //We need to typecast obj to ITestInterface to call the Sub
            //method because Sub method is implemented using Interface name
            ((ITestImterface)interfaceImplement).Sub(80, 40);



            //We can call the method directly using the interface reference
            //Typecasting is not required in this case
            ITestImterface testImterface = new InterfaceImplement();
            testImterface.Add(4, 4);
            testImterface.Sub(8, 4);


        }
    }

    interface ITestImterface
    {
        void Add (int number1, int number2);
        void Sub (int number1, int number2);
    }

    public class InterfaceImplement : ITestImterface
    {
        public void Add(int number1, int number2)
        {
            Console.WriteLine($"Sum of {number1} and {number2} is {number1 + number2}");
        }

        void ITestImterface.Sub(int number1, int number2)
        {
            Console.WriteLine($"Subtraction of {number1} and {number2} is {number1 - number2}");
        }
    }
}