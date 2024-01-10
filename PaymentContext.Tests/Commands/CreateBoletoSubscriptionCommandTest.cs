
using PaymentContext.Domain.Commands;
using PaymentContext.Domain.Entities;


namespace PaymentContext.Tests.Commands
{
    [TestClass]
    public class CreateBoletoSubscriptionCommandTest
    {

        [TestMethod]
        public void ShouldreturnErroWhenNameIsInvalid()
        {
            var command = new CreateBoletoSubscriptionCommand();

            command.FirstName = "";
            command.Validate();

            Assert.AreEqual(false, command.IsValid);
        }
    }
}
