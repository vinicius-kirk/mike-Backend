using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Mike.Interface.Services;
using System;

namespace Mike.Application.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : BaseApiController
    {
        protected readonly ICustomerService _customerService;
        public CustomerController(ILogger<CustomerController> logger,
                                  ICustomerService customerService) : base(logger)
        {
            _customerService = customerService;
        }

        [HttpGet]
        [Route("get/{id}")]
        public IActionResult Get(string id)
        {
            try
            {
                var data = _customerService.GetCustomerByID(id);

                return Ok(data);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                return new StatusCodeResult(500);
            }
        }
    }
}
