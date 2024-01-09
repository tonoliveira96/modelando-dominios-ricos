using PaymentContext.Domain.ValueObjects;
using PaymentContext.Shared.Entities;

namespace PaymenContext.Domain.Entities
{
    public class Student: Entity
    {
        private IList<Subscription> _subscriptions;
        public Student(Name name, Document document, string email)
        {
            Name = name;
            Document = document;
            Email = email;
            _subscriptions = new List<Subscription>();
        }

        public Name Name { get; set; }
        public Document Document { get; private set; }
        public string Email { get; private set; }
        public string Address { get; private set; }
        public IReadOnlyCollection<Subscription> Subscriptions { get { return _subscriptions.ToArray(); } }

        public void AddSubscription(Subscription subscription)
        {
            foreach (var sub in Subscriptions)
                sub.Inactivated();
                 _subscriptions.Add(subscription);
        }
    }
}