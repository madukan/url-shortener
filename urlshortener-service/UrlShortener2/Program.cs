var builder = WebApplication.CreateBuilder(args);

/// <summary>
/// Main entry point class for the URL shortening 
/// service. This initiates the WebAPI, and future
/// the swagger interfaces and related controllers
/// </summary>
builder.Services.AddControllers();

// Swagger related 
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Swagger UI is used only during the development 
// In production for security reasons, this will 
// be left switched off.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
