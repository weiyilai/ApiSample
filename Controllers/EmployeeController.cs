using ApiSample.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiSample.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeService _employeeService;


        public EmployeeController(
            IEmployeeService employeeService
            )
        {
            _employeeService = employeeService;
        }

        [Route("ById")]
        [HttpGet]
        public async Task<IActionResult> ById([FromQuery] int empNo)
        {
            return Ok(await _employeeService.GetEmployee(empNo));
        }

        [HttpGet]
        public async Task<IActionResult> Get([FromQuery] string deptNo)
        {
            return Ok(await _employeeService.GetEmployees(deptNo));
        }
    }
}
