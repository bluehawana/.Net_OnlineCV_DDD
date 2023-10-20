using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;



var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();  // This line is changed to add MVC views

// Comment out or remove Swagger if you don't need it anymore
//builder.Services.AddEndpointsApiExplorer();
//builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    // Comment out or remove Swagger if you don't need it anymore
    //app.UseSwagger();
    //app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseStaticFiles();  // Important to serve static files like CSS, JS, etc.

app.UseRouting();

app.UseAuthorization();

app.UseEndpoints(endpoints =>
{
    
        endpoints.MapControllerRoute(
        name: "default",
        pattern: "{controller=CV}/{action=Index}/{id?}");  // This sets the default route to CV/Index
    
}
    );
app.Run();

