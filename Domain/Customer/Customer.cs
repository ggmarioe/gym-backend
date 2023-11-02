using Domain.Primitives;
using Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Customer
{
    public sealed class Customer : AggregateRoot
    {
        public CustomerId Id { get; private set; }  
        public string Name { get; private set; } = string.Empty;
        public string LastName { get; private set; } = string.Empty;
        public string FullName => $"{Name} {LastName}";
        public string Email { get; private set; } = string.Empty;   
        public PhoneNumber PhoneNumber { get; private set; }
        public Address Address { get; private set; }
        public bool IsActive { get; set; }


        private Customer() { }

        public Customer(CustomerId id, string name, string lastName, string email, PhoneNumber phoneNumber, Address address, bool isActive)
        {
            Id = id;
            Name = name;
            LastName = lastName;
            Email = email;
            PhoneNumber = phoneNumber;
            Address = address;
            IsActive = isActive;
        }


    }   


}
