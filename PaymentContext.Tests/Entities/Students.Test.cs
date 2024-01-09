using PaymenContext.Domain.Entities;
using PaymentContext.Domain.ValueObjects;

namespace PaymenContext.Test
{
    [TestClass]
    public class StudentTests
    {
        [TestMethod]
        public void TestMethod()
        {
            var name = new Name("teste", "teste");
            foreach (var not in name.Notifications)
            {
                not.Message;
            }
        }
    }
}