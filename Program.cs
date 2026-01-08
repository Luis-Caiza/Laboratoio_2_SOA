using Microsoft.EntityFrameworkCore;
using ServicioClientesSOA.Data;
using ServicioClientesSOA.Services;
using CoreWCF;
using CoreWCF.Configuration;


var builder = WebApplication.CreateBuilder(args);

// 🔹 Entity Framework + PostgreSQL
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseNpgsql(
        "Host=localhost;Port=5432;Database=Soap;Username=postgres;Password="
    )
);

// Registrar ClienteService en el contenedor de DI
builder.Services.AddTransient<ClienteService>();
builder.Services.AddTransient<TipoProductoService>();
builder.Services.AddTransient<ProductoService>();

// 🔹 CoreWCF
builder.Services.AddServiceModelServices();
builder.Services.AddServiceModelMetadata();

// 🔹 CORS
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAngular", p =>
        p.AllowAnyOrigin()
         .AllowAnyHeader()
         .AllowAnyMethod());
});

var app = builder.Build();

app.UseCors("AllowAngular");

app.UseServiceModel(serviceBuilder =>
{
    serviceBuilder.AddService<ClienteService>();
    serviceBuilder.AddServiceEndpoint<ClienteService, IClienteService>(
        new BasicHttpBinding(),
        "/ClienteService.svc");

    serviceBuilder.AddService<TipoProductoService>();
    serviceBuilder.AddServiceEndpoint<TipoProductoService, ITipoProductoService>(
        new BasicHttpBinding(),
        "/TipoProductoService.svc");

    serviceBuilder.AddService<ProductoService>();
    serviceBuilder.AddServiceEndpoint<ProductoService, IProductoService>(
        new BasicHttpBinding(),
        "/ProductoService.svc");

    // Habilitar metadata/WSDL
    var behavior = app.Services.GetRequiredService<CoreWCF.Description.ServiceMetadataBehavior>();
    behavior.HttpGetEnabled = true;
});

app.Run();
