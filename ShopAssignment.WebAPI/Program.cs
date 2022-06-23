using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using ShopAssignment.Application.Catalog.Products;
using ShopAssignment.Application.Common;
using ShopAssignment.Data.Context;
using ShopAssignment.Utilities.Constants;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
//builder.Services.AddRazorPages(); 
//builder.Services.AddMvc()
//                    .AddControllersAsServices();
builder.Services.AddDbContext<ShopAssignmentDBContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString(SystemConstants.MainConnectionString)));


//Declare DI
builder.Services.AddTransient<IStorageService, FileStorageService>();
builder.Services.AddTransient<IProductService, ProductService>();

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
c.SwaggerDoc("v1", new OpenApiInfo { Title = "Swagger ShopAssignment Solution", Version = "v1" });

//c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
//{
//    Description = @"JWT Authorization header using the Bearer scheme. \r\n\r\n
//                      Enter 'Bearer' [space] and then your token in the text input below.
//                      \r\n\r\nExample: 'Bearer 12345abcdef'",
//    Name = "Authorization",
//    In = ParameterLocation.Header,
//    Type = SecuritySchemeType.ApiKey,
//    Scheme = "Bearer"
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
   
}
app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.UseSwagger();

app.UseSwaggerUI(c =>
{
    c.SwaggerEndpoint("/swagger/v1/swagger.json", "Swagger ShopAssignment V1");
});

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute(
        name: "default",
        pattern: "{controller=Home}/{action=Index}/{id?}");
});

//app.MapRazorPages();

app.MapControllers();

app.Run();
