namespace Exemple.Polimorifism
{
    public class Produs
    {
        private GenericLogger<Produs> _logger;
        public string Name { get; set; }
        public string Description { get; set; }

        public decimal Price { get; set; }

        public decimal DiscountRate { get; set; }

        public Produs(string name, string description, decimal price, decimal discountRate)
        {
            Name = name;S
            Description = description;
            Price = price * (1 - discountRate);
            _logger = new GenericLogger<Produs>();
            if (discountRate < 0 || discountRate > 1)
            {
                _logger.Log("Discount invalid");
            }else
            {
                DiscountRate = discountRate;
            }
        }

        public virtual void ApplyDiscountRate(decimal discountRate)
        {
            if (discountRate < 0 || discountRate > 1)
            {
                _logger.Log("Discount invalid");
                return;
            }
            DiscountRate = discountRate;
            Price = Price * (1 - discountRate);
        }

        public void RemoveDiscountRate()
        {
            Price = Price / (1 - DiscountRate);
            DiscountRate = 0;
        }

        public override string ToString()
        {
            return $"Name: {Name}, Description: {Description}, Price: {Price}, DiscountRate: {DiscountRate}";
        }
    }
}
