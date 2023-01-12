using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SalesChartDemo.Contracts;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace GoogleCharts.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SalesVisualizerController : ControllerBase
    {
        private readonly ILogger<SalesVisualizerController> _logger;
        private readonly IMapper _mapper;
        private readonly ISalesService _salesService;

        public SalesVisualizerController(
            ILogger<SalesVisualizerController> logger,
            IMapper mapper,
            ISalesService salesService)
        {
            _salesService = salesService;
            _logger = logger;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var chart = (await _salesService.GetAllAsync()).FirstOrDefault();
            int dataLength = chart.Data.Count()+1;

            object[][] dataArray = new object[dataLength][];

            dataArray[0] = new object[] { "Task", "Sale per month" };

            for (int i = 1; i < dataLength; i++)
            {
                dataArray[i] = new object[] { chart.Data.ElementAt(i-1).Month, chart.Data.ElementAt(i-1).Value };
            }

            return Ok(new
            {
                Name = chart.Name,
                ChartType = chart.ChartType,
                Options = new  { Is3D = chart.Options.Is3D, Title = chart.Options.Title},
                Width = chart.Width,
                Height = chart.Height,
                Data = dataArray

            });
        }

    }
}
