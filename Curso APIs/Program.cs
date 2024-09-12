var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//Inyecion de dependencias
/*Escogemos la interfaz IHelloWordService y le decimos que la dependencia es HelloworldService, es decir cada vez que se inyecte 
IHelloWordService lo que va a pasar es que se va a crea un nuevo objecto de HelloworldService internamente esto es lo que va hacer
el inyector

*/
//builder.Services.AddScoped<IHelloWordService, HelloworldService>();

//builder.Services.AddScoped<IHelloWordService>(p => new HelloworldService());
//builder.Services.AddScoped<ILogerService, LoggerService>();
//builder.Services.AddLogging();
//builder.Services.AddTransient<IComponent, ExternalServiceComponet>();
builder.Services.AddScoped<ILoggerService, LoggerService>();



var app = builder.Build();

// Configure the HTTP request pipeline.

// Use son los Middlewares

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

//app.UseWelcomePage();
//app.UseTimeMiddleware();

app.UseAuthorization();

app.MapControllers();

app.Run();
