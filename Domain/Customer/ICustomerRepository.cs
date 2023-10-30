using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Customer
{
    public interface ICustomerRepository
    {
        Task<Customer> GetByIdAsync(CustomerId Id);
        Task<Customer> Add(Customer customer);
    }
}
