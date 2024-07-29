namespace Exemple.Solid
{

    // Interfață unică care combină toate funcționalitățile (încalcă ISP)
    interface ICopier
    {
        void Copy(string document);
    }

    interface IPrinter
    {
        void Print(string document);
    }

    interface IScanner
    {
        void Scan(string document);
    }

    // Clasă care implementează interfața IMultiFunctionDevice
    class AllInOnePrinter : ICopier, IScanner, IPrinter
    {
        public void Print(string document)
        {
            Console.WriteLine($"Printing: {document}");
        }

        public void Scan(string document)
        {
            Console.WriteLine($"Scanning: {document}");
        }

        public void Copy(string document)
        {
            Console.WriteLine($"Copying: {document}");
        }
    }

    // Clasă care implementează interfața IMultiFunctionDevice, dar folosește doar funcționalitatea de printare (încalcă ISP)
    class BasicPrinter : IPrinter
    {
        public void Print(string document)
        {
            Console.WriteLine($"Printing: {document}");
        }
    }

    /*class PrinterProgram
    {
        static void Main(string[] args)
        {
            IPrinter printer = new BasicPrinter();
            printer.Print("Hello, World!");


        }
    }*/

}
