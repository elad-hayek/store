using CustomerService.Application;
using CustomerService.Presistence;
using CustomerService.WebApi;
using Mapster;
using MapsterMapper;
using MediatR;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// controllers
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddControllers().AddApplicationPart(AssemblyRefrences.Presentation);

// mapster
var mapsterConfig = TypeAdapterConfig.GlobalSettings.Scan(Assembly.GetExecutingAssembly());
builder.Services.AddSingleton(mapsterConfig);
builder.Services.AddScoped<IMapper, ServiceMapper>();

//mediatR
builder.Services.AddMediatR(AssemblyRefrences.Application);

// other
new ApplicationRegistrations().RegisterServices(builder);
new PresistenceRegistrations().RegisterServices(builder);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
