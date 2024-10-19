
var builder = WebApplication.CreateBuilder(args);

builder.Host.UseSerilog((context, config) => config.ReadFrom.Configuration(context.Configuration));

builder.Services.AddCarterWithAssemblies(typeof(CatalogModule).Assembly);

// Configure CORS
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll", builder =>
    {
        builder.AllowAnyOrigin()
               .AllowAnyMethod()
               .AllowAnyHeader();
    });
});

builder.Services
    .AddCatalogModule(builder.Configuration)
    .AddBasketModule(builder.Configuration)
    .AddOrderingModule(builder.Configuration);

builder.Services.AddExceptionHandler<CustomExceptionHandler>();

var app = builder.Build();

// Use CORS
app.UseCors("AllowAll");

app.MapCarter();
app.UseSerilogRequestLogging();
app.UseExceptionHandler(o => {});

app
    .UseCatalogModule()
    .UseBasketModule()
    .UseOrderModule();


app.Run();
