using CustomerService.Application.Customers.Commands.CreateCustomer;
using Mapster;

namespace CustomerService.WebApi;

public class MapsterRegistrations : IRegister
{
    void Register(TypeAdapterConfig config)
    {
        config.NewConfig<CreateCustomerRequest, CreateCustomerCommand>();
    }
}
