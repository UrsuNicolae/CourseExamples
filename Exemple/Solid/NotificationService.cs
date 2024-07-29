namespace Exemple.Solid
{

    // Clasa EmailService fără interfață

    interface IMessageService
    {
        void Send(string message);
    }


    class EmailService : IMessageService
    {
        public void Send(string message)
        {
            Console.WriteLine($"Sending email 2.1: {message}");
        }
    }

    class EmailService2 : IMessageService
    {
        public void Send(string message)
        {
            Console.WriteLine($"Sending email 2.2: {message}");
        }
    }

    class SmsService : IMessageService
    {
        public void Send(string message)
        {
            Console.WriteLine($"Sending SMS: {message}");
        }
    }

    class NotificationService1
    {
        private IMessageService _mesageService;

        public NotificationService1(IMessageService messageService)
        {
            _mesageService = messageService;
        }

        public void Notify(string message)
        {
            _mesageService.Send(message);
            //...
        }
    }

    /*class NotificationProgram
    {
        static void Main(string[] args)
        {
            IMessageService emailService = new SmsService();
            var notificationService = new NotificationService(emailService);

            notificationService.Notify("Hello, World!");
        }
    }*/

}
