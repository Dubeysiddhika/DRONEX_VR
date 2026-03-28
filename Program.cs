/*using DroneX_API.Services;

var builder = WebApplication.CreateBuilder(args);

builder.WebHost.UseUrls("http://localhost:5180");

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// MongoDB Service
builder.Services.AddSingleton<MongoDbService>();

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

app.UseAuthorization();

app.MapControllers();

app.Run();*//*
             * 
             * 
using DroneX_API.Services;

var builder = WebApplication.CreateBuilder(args);

// Server URL
builder.WebHost.UseUrls("http://localhost:5180");

// Add services
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// MongoDB Service
builder.Services.AddSingleton<MongoDbService>();

// CORS (Unity requests allow karne ke liye)
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowUnity",
        policy =>
        {
            policy.AllowAnyOrigin()
                  .AllowAnyMethod()
                  .AllowAnyHeader();
        });
});

var app = builder.Build();

// Enable Swagger
app.UseSwagger();
app.UseSwaggerUI();

// Enable CORS
app.UseCors("AllowUnity");

app.UseAuthorization();

app.MapControllers();

app.Run();*/

/*using DroneX_API.Services;

var builder = WebApplication.CreateBuilder(args);

builder.WebHost.UseUrls("http://localhost:5180");

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddSingleton<MongoDbService>();

builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowUnity",
        policy =>
        {
            policy.AllowAnyOrigin()
                  .AllowAnyMethod()
                  .AllowAnyHeader();
        });
});

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

app.UseCors("AllowUnity");

app.UseAuthorization();

app.MapControllers();

app.Run();*/



using DroneX_API.Services;

var builder = WebApplication.CreateBuilder(args);

// ✅ PORT
builder.WebHost.UseUrls("http://localhost:5180");

// ✅ SERVICES
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// ✅ Mongo
builder.Services.AddSingleton<MongoDbService>();

// ✅ CORS
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowUnity", policy =>
    {
        policy.AllowAnyOrigin()
              .AllowAnyMethod()
              .AllowAnyHeader();
    });
});

var app = builder.Build();

// ✅ Swagger
app.UseSwagger();
app.UseSwaggerUI();

// ✅ CORS
app.UseCors("AllowUnity");

// ❌ REMOVE (abhi login system nahi hai)
// app.UseAuthorization();

app.MapControllers();

app.Run();