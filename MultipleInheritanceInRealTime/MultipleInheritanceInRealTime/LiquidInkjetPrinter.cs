using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleInheritanceInRealTime
{
    public class LiquidInkjetPrinter : IPrinterTasks
    {
        public void Print(string PrintContent)
        {
            Console.WriteLine(PrintContent);
        }
        public void Scan(string ScanContent)
        {
            Console.WriteLine(ScanContent);
        }
    }
}
