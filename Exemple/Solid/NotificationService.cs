using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemple.Solid
{
    using System;

    // Clasa EmailService fără interfață
    class EmailService
    {
        public void Send(string message)
        {
            Console.WriteLine($"Sending email: {message}");
        }
    }

    class NotificationService
    {
        private EmailService _emailService;

        public NotificationService(EmailService emailService)
        {
            _emailService = emailService;
        }

        public void Notify(string message)
        {
            _emailService.Send(message);
        }
    }

    class NotificationProgram
    {
        static void Main(string[] args)
        {
            EmailService emailService = new EmailService();
            NotificationService notificationService = new NotificationService(emailService);

            notificationService.Notify("Hello, World!");
        }
    }

}
