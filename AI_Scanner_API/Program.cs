using AI_Scanner_DB.Repositories;
using AI_Scanner_Service.IManagers;
using AI_Scanner_Service.IRepositories;
using AI_Scanner_Service.Managers;
using AI_Scanner_User.Managers;
using AI_Scanner_User.IManagers;
using AI_Scanner_User.IRepositories;
using AI_Scanner_API.Config;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

builder.Services.Configure<AIscannerDatabaseSettings>(
    builder.Configuration.GetSection("AIScannerDatabase"));

builder.Services.AddScoped<IAIManager, AIServiceManager>();
builder.Services.AddScoped<IUserManager, UserManager>();

builder.Services.AddScoped<IAIServiceRepository, AIRepository>();
builder.Services.AddScoped<IUserRepository, UserRepository>();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();
app.MapControllers();

app.Run();