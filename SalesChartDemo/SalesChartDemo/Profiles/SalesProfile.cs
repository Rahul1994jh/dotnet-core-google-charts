using AutoMapper;
using SalesChartDemo.Dtos;
using SalesChartDemo.Entites;

namespace SalesChartDemo.Profiles
{
    public class SalesProfile : Profile   
    {
        public SalesProfile()
        {
            CreateMap<Sale, SaleDto>();
        }
    }
}
