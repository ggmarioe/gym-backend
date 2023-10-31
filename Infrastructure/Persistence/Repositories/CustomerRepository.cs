using Domain.Customer;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Persistence.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        private ApplicationDbContext _context;
        public CustomerRepository(ApplicationDbContext context) { 
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public async Task Add(Customer customer) => await _context.Customers.AddAsync(customer);

        public async Task GetByIdAsync(CustomerId Id) => await _context.Customers.SingleOrDefaultAsync(x => x.Id == Id);    
    }   
}

   
