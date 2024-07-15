using Exemple.EncapsulationAndAbstraction.Log;

namespace Exemple.EncapsulationAndAbstraction.LogExercise
{
    public class PaymentManagement
    {
        private ILogger _logger;

        public PaymentManagement(ILogger logger)
        {
            _logger = logger;
        }

        public void ProcessPayment(double amount)
        {
            if (amount < 0)
            {
                _logger.LogError("Invalid payment amount");
                return;
            }

            _logger.LogInformation($"Payment processed for {amount}");
        }

        public void RefundPayment(double amount)
        {
            if (amount < 0)
            {
                _logger.LogError("Invalid refund amount");
                return;
            }

            _logger.LogInformation($"Payment refunded for {amount}");
        }

        public void ProcessRefund(double amount)
        {
            if (amount < 0)
            {
                _logger.LogError("Invalid refund amount");
                return;
            }

            _logger.LogInformation($"Refund processed for {amount}");
        }
    }
}
