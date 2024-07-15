using Exemple.ClassMembers;
using Exemple.Encapsulation;
using Exemple.EncapsulationAndAbstraction;
using Exemple.EncapsulationAndAbstraction.LogExercise;
using System.Runtime.CompilerServices;
using Car = Exemple.EncapsulationAndAbstraction.Car;

namespace Exemple
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var consoleLogger = new ConsoleLogger();
            var path = "C:\\Users\\NURSU\\Desktop\\Curs\\log.txt";
            var fileLogger = new FileLogger(path);
            var paymentManagement = new PaymentManagement(fileLogger);
            paymentManagement.ProcessPayment(100);
            paymentManagement.RefundPayment(50);
            paymentManagement.ProcessPayment(-1);
        }
    }
}
