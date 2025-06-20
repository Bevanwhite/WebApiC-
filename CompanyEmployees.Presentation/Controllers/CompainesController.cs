using Microsoft.AspNetCore.Mvc;
using Service.Contracts;

namespace CompanyEmployees.Presentation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompainesController : ControllerBase
    {
        private readonly IServiceManager _service;

        public CompainesController(IServiceManager service) => _service = service;

        [HttpGet]
        public IActionResult GetCompanies()
        {
            try
            {
                var companies = _service.CompanyService.GetAllCompanies(trackChanges: false);
                return Ok(companies);
            }
            catch
            {
                return StatusCode(500, "Internal server error");
            }
        }

    }
}