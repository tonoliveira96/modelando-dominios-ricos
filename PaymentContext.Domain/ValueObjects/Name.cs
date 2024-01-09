

using PaymentContext.Shared.ValueObjects;

namespace PaymentContext.Domain.ValueObjects
{
   public class Name: ValueObject
    {
        public Name(string firstName, string fLastName)
        {
            FirstName = firstName;
            FLastName = fLastName;
        }

        public string FirstName { get; private set; }
        public string FLastName { get; private set; }
    }
}
