using Microsoft.AspNetCore.Builder;

namespace CustomerService.Domain.Abstractions;

public interface IServiceRegistrator
{
    void RegisterServices(WebApplicationBuilder builder);
}
