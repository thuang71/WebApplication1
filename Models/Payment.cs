namespace WebApplication1.Models
{
    public class Payment
    {

        public string? CreditCardNumber { get; set; }
        public string? ExpirationDate { get; set; }
        public string? CVV { get; set; }
        public decimal Amount { get; set; }

    }
}
