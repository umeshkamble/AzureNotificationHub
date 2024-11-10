using AZNotificationHub.Authentication;
using AZNotificationHub.Models;
using AZNotificationHub.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddAuthentication(options =>
{
    options.DefaultAuthenticateScheme = ApiKeyAuthOptions.DefaultScheme;
    options.DefaultChallengeScheme = ApiKeyAuthOptions.DefaultScheme;
}).AddApiKeyAuth(builder.Configuration.GetSection("Authentication").Bind);

builder.Services.AddSingleton<INotificationService, NotificationHubService>();
builder.Services.AddOptions<NotificationHubOptions>()
    .Configure(builder.Configuration.GetSection("NotificationHub").Bind)
    .ValidateDataAnnotations();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}


app.UseHttpsRedirection();
app.UseRouting();
app.UseAuthentication();
app.UseAuthorization();
app.MapControllers();

app.Run();
