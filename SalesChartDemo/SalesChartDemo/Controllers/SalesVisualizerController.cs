using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SalesChartDemo.Contracts;
using SalesChartDemo.Dtos;
using System.Threading.Tasks;

namespace SalesChartDemo.Controllers
{
    [Route("api/[controller]")]
    public class SalesVisualizerController : Controller
    {

        private readonly ILogger<SalesVisualizerController> _logger;
        private readonly IMapper _mapper;
        private readonly ISalesService _salesService;

        public SalesVisualizerController(
            ILogger<SalesVisualizerController> logger,
            IMapper mapper,
            ISalesService salesService
            )
        {
            _salesService = salesService;
            _logger = logger;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var sales =  await _salesService.GetAllAsync();
            var saleDto = _mapper.Map<SaleDto>(sales);
            return Ok(saleDto);
        }
    }
}
