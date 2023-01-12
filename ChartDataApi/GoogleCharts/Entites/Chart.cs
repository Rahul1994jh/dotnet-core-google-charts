using Newtonsoft.Json;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata;

namespace SalesChartDemo.Entites
{
    public class Chart
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public string ChartType { get; set; }

        public string Width { get; set; }

        public string Height { get; set; }

        public Options Options { get; set; }

        public IEnumerable<DataNum> Data { get; set; }

    }

    public class Options
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public bool Is3D { get; set; }

        public int ChartId { get; set; }
    }

    public class DataNum
    {
        public int Id { get; set; }

        public string Month { get; set; }

        public long Value { get; set; }

        public int ChartId { get; set; }
    }

}
