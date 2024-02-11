//Console.WriteLine("Hello, OS");

namespace MultipleInterface
{
    interface ICar
    {
        void Drive();
    }

    interface IBike
    {
        void Drive();
    }

    class Program : ICar, IBike
    {
        void ICar.Drive() 
        {
            Console.WriteLine("Car Drive.");
        }

        void IBike.Drive()
        {
            Console.WriteLine("Bike drive.");
        }

        static void Main(string[] args)
        {
            Program program = new Program();

            ((ICar)program).Drive();
            ((IBike)program).Drive();

            (program as ICar).Drive();
            (program as IBike).Drive();
        }
    }
}