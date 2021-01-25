using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiVersioning.Model
{
    public class BudgetV1
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Desc { get; set; }
        public DateTime EntryDate { get; set; }
        public string Version { get; set; }
    }

    public class BudgetV2
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Desc { get; set; }
        public DateTime EntryDate { get; set; }
        public string Version { get; set; }
    }
}
