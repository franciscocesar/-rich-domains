using PaymentContext.Domain.Entities.ValueObjects;

namespace PaymentContext.Domain.Entities
{
    public abstract class Payment 
    {
        protected Payment(DateTime expireDate, DateTime paidDate, decimal total, decimal totalPaid, Document document, string owner, string address, string email)
        {
            Number = Guid.NewGuid().ToString().Replace("-", "").Substring(0, 10).ToUpper();
            ExpireDate = expireDate;
            PaidDate = paidDate;
            Total = total;
            TotalPaid = totalPaid;
            Document = document;
            Owner = owner;
            Address = address;
            Email = email;
        }

        public string Number { get; set; }
        public DateTime ExpireDate { get; set; }
        public DateTime PaidDate { get; set; }
        public decimal Total { get; set; }
        public decimal TotalPaid { get; set; }
        public Document Document { get; set; }
        public string Owner { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
    }

}