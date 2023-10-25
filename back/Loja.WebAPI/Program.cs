using Loja.Application.Mappings;
using Loja.Application.Services.Products;
using Loja.Application.Services.Supprier;
using Loja.Application.Services.UnitMeasure;
using Loja.Domain.Interfaces;
using Loja.Domain.Repositories;
using Loja.Infrastructure.Data.Contexts;
using Loja.Infrastructure.Repositories;
using Microsoft.OpenApi.Models;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers()
    .AddNewtonsoftJson(x =>
    {
        x.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore;
    });

builder.Services.AddScoped<IProductService, ProductService>();
builder.Services.AddScoped<IUnitMeasureService, UnitMeasureService>();
builder.Services.AddScoped<ISupplierService, SupplierService>();
builder.Services.AddScoped<IProductRepository, ProductRepository>();
builder.Services.AddScoped<IUnitMeasureRepository, UnitMeasureRepository>();
builder.Services.AddScoped<ISupplierRepository, SupplierRepository>();
builder.Services.AddAutoMapper(typeof(DomainToDTOMappingProfile));
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddCors();
builder.Services.AddSqlServer<ApplicationDbContext>(builder.Configuration["ConnectionStrings:Default"]);
builder.Services.AddSwaggerGen(options =>
{
    options.SwaggerDoc("v1", new OpenApiInfo
    {
        Title = "Loja.WebAPI",
        Version = "v1",
        Contact = new OpenApiContact
        {
            //Name = "Name",
            //Email = "",
            //Url = new Uri("site"),
        }
    });

    var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
    var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
    options.IncludeXmlComments(xmlPath);
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors(c =>
{
    c.AllowAnyOrigin();
    c.AllowAnyHeader();
    c.AllowAnyMethod();
});

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
