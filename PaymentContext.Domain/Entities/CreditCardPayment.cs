namespace PaymentContext.Domain.Entities
{

    public class CreditCardPayment : Payment
    {
        public CreditCardPayment(
        string cardHolderName, 
        string cardNumber, 
        string lastTransactionNumber,
        DateTime expireDate, 
        DateTime paidDate, 
        decimal total, 
        decimal totalPaid, 
        string document, 
        string owner, 
        string address, 
        string email) : base( expireDate,  paidDate,  total,  totalPaid,  document,  owner,  address,  email)
        {
            CardHolderName = cardHolderName;
            CardNumber = cardNumber;
            LastTransactionNumber = lastTransactionNumber;
        }

        public string CardHolderName { get; private set; }
        public string CardNumber { get; private set; }
        public string LastTransactionNumber { get; private set; }
    }

}