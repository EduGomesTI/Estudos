using System.Collections.Generic;
using System.Linq;
using Flunt.Validations;
using PaymentContext.Domain.ValueObjects;
using PaymentContext.Shared.Entities;

namespace PaymentContext.Domain.Entities
{
    public class Student: Entity
    {
        public Name Name { get; private set; }
        public Document Document { get; private set; }
        public Email Email { get; private set; }
        public Address Address { get; private set; }
        public IReadOnlyCollection<Subscription> Subscriptions { get { return _subscription.ToArray(); } }
        private IList<Subscription> _subscription;
        public Student(Name name, Document document, Email email)
        {
            Name = name;
            Document = document;
            Email = email;
            _subscription = new List<Subscription>();

            AddNotifications(name, document, email);
        }

        public void AddSubscription(Subscription subscription)
        {
            var hasSubscriptionActive = false;
            foreach(var sub in _subscription)
            {
                if(sub.Active)
                {
                    hasSubscriptionActive = true;
                }
            }
            AddNotifications(new Contract()
            .Requires()
            .IsFalse(hasSubscriptionActive, "Student.Subscriptions", "Você já tem uma assinatura ativa.")
            .AreEquals(0, subscription.Payments.Count, "Student.Subscription.Payments", "Esta assinatura não possui pagaamentos.")
            );
        }
    }
}