using System.Collections.Generic;
using System.Linq;
using NewStore.Domain.StoreContext.ValueObjects;
using NewStore.Shared.Entities;

namespace NewStore.Domain.StoreContext.Entities
{
    public class Customer : Entity
    {
        private readonly IList<Address> _addresses;
        public Customer(Name name, Document document, Email email, string phone)
        {
            ChangeName(name);
            ChangeDocument(document);
            ChangeEmail(email);
            ChangePhone(phone);
            _addresses = new List<Address>();
        }

        public Name Name { get; private set; }
        public Document Document { get; private set; }
        public Email Email { get; private set; }
        public string Phone { get; private set; }
        public IReadOnlyCollection<Address> Addresses => _addresses.ToArray();

        public void AddAddress(Address address)
        {
            AddNotifications(address.Notifications);
            _addresses.Add(address);
        }

        public void ChangeName(Name name)
        {
            AddNotifications(name.Notifications);
            Name = name;
        }

        public void ChangeDocument(Document document)
        {
            AddNotifications(document.Notifications);
            Document = document;
        }

        public void ChangeEmail(Email email)
        {
            AddNotifications(email.Notifications);
            Email = email;
        }

        public void ChangePhone(string phone)
        {
            Phone = phone;
        }

        public override string ToString()
        {
            return Name.ToString();
        }

    }
}