WebApplicationBuilder builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();
WebApplication app = builder.Build();

app.MapControllerRoute("default", "{controller=Home}/{action=Index}");
app.Run();
