using ApiCrud.Data;
using ApiCrud.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<ApplicationDbContext>(options =>
{
    options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection"));
});

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new Microsoft.OpenApi.Models.OpenApiInfo { Title = "Api Crud Products", Version = "v1" });
});
builder.Services.AddScoped<ProductService>();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "Api Crud Products v1");
    });
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.UseRouting();

app.UseEndpoints(endpoints =>
{
    _ = endpoints.MapControllers();
});

app.Run();
