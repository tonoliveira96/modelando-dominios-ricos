using PaymenContext.Domain.Entities;

namespace PaymenContext.Test
{
    [TestClass]
    public class StudentTests
    {
        [TestMethod]
        public void TestMethod()
        {
            var subscription = new Subscription(null);
            var student = new Student("Everton", "Oliveira", "1200000", "tonn.oliveira2011@gmail.com");
            student.AddSubscription(subscription);
        }
    }
}