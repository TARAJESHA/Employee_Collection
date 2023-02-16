using FInalMVC.Controllers;
using FInalMVC.Servicess;
using FInalMVC.Servicess.Interface;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.


/*builder.Services.AddTransient<IAEmployee, IAEmployeeService> ();
 */
builder.Services.AddScoped<IPermanent, EmployeeService>();
builder.Services.AddScoped<Temporary, EmployeeService>();
builder.Services.AddControllersWithViews();

var app = builder.Build();
 

Console.WriteLine("I am here");
// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
