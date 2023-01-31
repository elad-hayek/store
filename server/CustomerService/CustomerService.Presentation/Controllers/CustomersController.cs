using CustomerService.Application.Customers;
using CustomerService.Application.Customers.Commands.CreateCustomer;
using Microsoft.AspNetCore.Mvc;
using System.Web.Http;
using HttpGet = Microsoft.AspNetCore.Mvc.HttpGetAttribute;
using HttpPost = Microsoft.AspNetCore.Mvc.HttpPostAttribute;
using FromBody = Microsoft.AspNetCore.Mvc.FromBodyAttribute;
using Microsoft.AspNetCore.Http;
using CustomerService.Domain.Entities;

namespace CustomerService.Presentation.Controllers;

public sealed class CustomersController : ApiController
{
    private readonly CustomerManager _customerManager;

    public CustomersController(CustomerManager customerManager)
    {
        _customerManager = customerManager;
    }

    [HttpGet("getCustomerById/{id}")]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(Customer))]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> GetCustomerById([FromUri]int id, CancellationToken cancellationToken)
    {
        var res = await _customerManager.GetCustomerById(id, cancellationToken);
        return res == null ? NotFound() : Ok(res);
    }

    [HttpPost("CreateCustomer")]
    public async Task<IActionResult> GetCustomerById([FromBody] CreateCustomerRequest request, CancellationToken cancellationToken)
    {
        var res = await _customerManager.CreateCustomer(request, cancellationToken);

        return (IActionResult)Create(nameof(GetCustomerById), new { res }, res);
    }
}
