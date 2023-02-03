using CustomerService.Application.Customers;
using CustomerService.Application.Customers.Commands.CreateCustomer;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using CustomerService.Domain.Entities;

namespace CustomerService.Presentation.Controllers;

[ApiController]
public sealed class CustomersController : ControllerBase
{
    private readonly CustomerManager _customerManager;

    public CustomersController(CustomerManager customerManager)
    {
        _customerManager = customerManager;
    }

    [HttpGet("getCustomerById/{id}")]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(Customer))]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> GetCustomerById([FromQuery]int id, CancellationToken cancellationToken)
    {
        var res = await _customerManager.GetCustomerById(id, cancellationToken);
        return res == null ? NotFound() : Ok(res);
    }

    [HttpPost("CreateCustomer")]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(int))]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> GetCustomerById([FromBody] CreateCustomerRequest request, CancellationToken cancellationToken)
    {
        try
        {
            var res = await _customerManager.CreateCustomer(request, cancellationToken);
            return CreatedAtAction(nameof(GetCustomerById), new { id = res }, res);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }

    }
}
