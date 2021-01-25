using ApiVersioning.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiVersioning.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [ApiVersion("1.0")]
    [ApiVersion("2.0")]
    public class BudgetController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetV1()
        {
            BudgetV1 data = new BudgetV1{
                Id = "10120230304040",
                Name = "2021 Budget of e-Novate",
                Desc = "This budget is aimed at providing the financial requirment for the research, development of the e-Novate Startup Funding",
                EntryDate = DateTime.Now,
                Version = "Version One"
            };

            return Ok(data);
        }



        [HttpGet]
        [MapToApiVersion("2.0")]
        public IActionResult GetV2()
        {
            BudgetV2 data = new BudgetV2
            {
                Id = "10120230304040",
                Name = "2021 Budget of e-Novate",
                Desc = "This budget is aimed at providing the financial requirment for the research, development of the e-Novate Startup Funding",
                EntryDate = DateTime.Now,
                Version = "Version Two"
            };

            return Ok(data);
        }
    }
}
