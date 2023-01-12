using Microsoft.EntityFrameworkCore;
using SalesChartDemo.Contracts;
using SalesChartDemo.Data;
using SalesChartDemo.Entites;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesChartDemo.Services
{
    public class SalesService : ISalesService
    {
        private readonly ApplicationDbContext _applicationDbContext;

        public SalesService(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        public async Task<IEnumerable<Sale>> GetAllAsync()
        {
            return await _applicationDbContext.Sales.ToListAsync();
        }
    }
}
