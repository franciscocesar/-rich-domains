using Microsoft.VisualStudio.TestTools.UnitTesting;
using PaymentContext.Domain.Entities;

namespace PaymentContext.Tests
{
    [TestClass]
    public class StudentTests
    {
        [TestMethod]
        public void AddSubscription()
        {
            var subscription = new Subscription(null);
            var student = new Student("Francisco", "César", "123456789", "francisco@gmail.com");
            
            student.AddSubscription(subscription);
        }
    }
}