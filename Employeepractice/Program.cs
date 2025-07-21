using BAL;
using DAL;
using Employeepractice.Filters;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.Extensions.Options;
using Microsoft.Identity.Web;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped<IBALEmployee, EmployeeBAL>();
builder.Services.AddScoped<IEmployeeDAL, EmployeeDAL>();
builder.Services.AddScoped<IStudentDAL, StudentDAL>();
builder.Services.AddScoped<IstudentBAL, StudentBAL>();
builder.Services.AddScoped<IcountryDAL, CountryDAL>();
builder.Services.AddScoped<IcountryBAL, CountryBAL>();

//Getcountries


// Add services to the container.

builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
    .AddMicrosoftIdentityWebApi(builder.Configuration.GetSection("AzureAd"));

builder.Services.AddAuthorization();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowSpecificOrigin", builder =>
    {
        builder.WithOrigins("http://localhost:3000") // React app's URL
               .AllowAnyMethod()
               .AllowAnyHeader();
    });
});

builder.Services.AddControllers(Options =>
{
    Options.Filters.Add<myexceptionfilter>();

});

var app = builder.Build();

app.UseCors("AllowSpecificOrigin");

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();



app.Run();
