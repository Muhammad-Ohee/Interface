//Console.WriteLine("Hello, OS");

namespace MultipleInheritanceInRealTime
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("OS");

            Console.WriteLine("HP Laser Jet Printer:");
            HPLaserJetPrinter hPLaserJetPrinter = new HPLaserJetPrinter();
            hPLaserJetPrinter.Scan("Scan Services by HPLaserJetPrinter");
            hPLaserJetPrinter.Print("Print Services by HPLaserJetPrinter");
            hPLaserJetPrinter.Fax("Fax Services by HPLaserJetPrinter");
            hPLaserJetPrinter.PrintDuplex("Print Duplex Services by HPLaserJetPrinter");

            Console.WriteLine("\nLiquid Inkjet Printer:");
            LiquidInkjetPrinter liquidInkjetPrinter = new LiquidInkjetPrinter();
            liquidInkjetPrinter.Scan("Scan Services by LiquidInkjetPrinter");
            liquidInkjetPrinter.Print("Print Services by LiquidInkjetPrinter");
        }
    }
}