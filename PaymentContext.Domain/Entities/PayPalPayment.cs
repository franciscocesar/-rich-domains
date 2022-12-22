namespace PaymentContext.Domain.Entities
{

    public class PayPalPayment : Payment
    {
        public PayPalPayment(
        string transactionCode, 
        DateTime expireDate, 
        DateTime paidDate, 
        decimal total, 
        decimal totalPaid, 
        string document, 
        string owner, 
        string address, 
        string email) : base( expireDate,  paidDate,  total,  totalPaid,  document,  owner,  address,  email)
        {
            TransactionCode = transactionCode;
        }

        public string TransactionCode { get; private set; }
    }
}