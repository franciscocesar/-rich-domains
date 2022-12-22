using PaymentContext.Domain.Entities.ValueObjects;

namespace PaymentContext.Domain.Entities
{

    public class BoletoPayment : Payment
    {
        public BoletoPayment(string barCode, 
        string boletoNumber,
        DateTime expireDate, 
        DateTime paidDate, 
        decimal total, 
        decimal totalPaid, 
        Document document, 
        string owner, 
        string address, 
        string email) : base( expireDate,  paidDate,  total,  totalPaid,  document,  owner,  address,  email)
        {
            BarCode = barCode;
            BoletoNumber = boletoNumber;
        }

        public string BarCode { get; private set; }
        public string BoletoNumber { get; private set; }

    }

}