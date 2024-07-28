namespace Exemple.Solid
{
    using System;

    // Interfață unică care combină toate funcționalitățile (încalcă ISP)
    interface IMultiFunctionDevice
    {
        void Print(string document);
        void Scan(string document);
        void Copy(string document);
    }

    // Clasă care implementează interfața IMultiFunctionDevice
    class AllInOnePrinter : IMultiFunctionDevice
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
    class BasicPrinter : IMultiFunctionDevice
    {
        public void Print(string document)
        {
            Console.WriteLine($"Printing: {document}");
        }

        public void Scan(string document)
        {
            throw new NotImplementedException("BasicPrinter does not support scanning.");
        }

        public void Copy(string document)
        {
            throw new NotImplementedException("BasicPrinter does not support copying.");
        }
    }

    class PrinterProgram
    {
        static void Main1(string[] args)
        {
            IMultiFunctionDevice printer = new BasicPrinter();
            printer.Print("Hello, World!");

            try
            {
                printer.Scan("Hello, World!"); // Va arunca o excepție
            }
            catch (NotImplementedException ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {
                printer.Copy("Hello, World!"); // Va arunca o excepție
            }
            catch (NotImplementedException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }

}
