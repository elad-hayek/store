using CustomerService.Application.Customers;
using CustomerService.Application.Customers.Commands.CreateCustomer;
using Microsoft.AspNetCore.Mvc;
using System.Web.Http;
using HttpGet = Microsoft.AspNetCore.Mvc.HttpGetAttribute;
using HttpPost = Microsoft.AspNetCore.Mvc.HttpPostAttribute;
using Route = Microsoft.AspNetCore.Mvc.RouteAttribute;
using FromBody = Microsoft.AspNetCore.Mvc.FromBodyAttribute;

namespace CustomerService.Presentation.Controllers;

public sealed class CustomersController : ApiController
{
    private readonly CustomerManager _customerManager;

    public CustomersController(CustomerManager customerManager)
    {
        _customerManager = customerManager;
    }

    [HttpGet]
    [Route("getCustomerById/{id}")]
    public async Task<IActionResult> GetCustomerById([FromUri]int id, CancellationToken cancellationToken)
    {
        var res = await _customerManager.GetCustomerById(id, cancellationToken);
        return (IActionResult)Ok(res);
    }

    [HttpPost]
    [Route("CreateCustomer")]
    public async Task<IActionResult> GetCustomerById([FromBody] CreateCustomerRequest request, CancellationToken cancellationToken)
    {
        var res = await _customerManager.CreateCustomer(request, cancellationToken);

        return (IActionResult)CreatedAtRoute(nameof(GetCustomerById), new { res }, res);
    }
}
