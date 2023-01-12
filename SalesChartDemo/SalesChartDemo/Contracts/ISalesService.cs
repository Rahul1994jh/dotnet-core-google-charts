using SalesChartDemo.Entites;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesChartDemo.Contracts
{
    public interface ISalesService
    {
        Task<IEnumerable<Sale>> GetAllAsync();
    }
}
