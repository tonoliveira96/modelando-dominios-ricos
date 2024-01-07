using PaymenContext.Domain.Entities;


namespace PaymentContext.Domain.Entities
{
    public class PayPalPayment : Payment
    {
        public PayPalPayment(string transacrionCode, DateTime paidDate, DateTime expireDate, decimal total, decimal totalPaid, string payer, string document, string address, string email) :
            base(paidDate, expireDate, total, totalPaid, payer, document, address, email)
        {
            TransacrionCode = transacrionCode;
        }

        public string TransacrionCode { get; private set; }
    }
}
