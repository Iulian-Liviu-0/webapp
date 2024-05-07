var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();

var app = builder.Build();
var env = builder.Environment;


app.MapControllerRoute(name: "home", pattern: "{controller=Home}/{action=HomePage}");

if (env.IsDevelopment() || env.IsStaging())
    {
        app.UseDeveloperExceptionPage();
    }

app.Run(context => {throw new Exception("Error"); });
