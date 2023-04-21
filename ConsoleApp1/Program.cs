using RawPrint;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = @"AAA.ps";
            var printerName = "Adobe PDF";//"CutePDF Writer"; //other printers work
            var printer = new Printer();
            printer.PrintRawFile(printerName, path, false);
        }
    }
}
