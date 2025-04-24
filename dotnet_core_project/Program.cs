using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.OpenApi.Models;
using שיעור_3;
using שיעור_3.Interfaces;
using שיעור_3.Services;
using שיעור_3.Middlewares;



var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services
        .AddAuthentication(options =>
        {
            options.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
        })
        .AddJwtBearer(cfg =>
        {
            cfg.RequireHttpsMetadata = false;
            cfg.TokenValidationParameters = ClothesTokenService.GetTokenValidationParameters();
        });

builder.Services.AddAuthorization(cfg =>
   {
       cfg.AddPolicy("Admin", policy => policy.RequireClaim("type","Admin"));
       cfg.AddPolicy("User", policy => policy.RequireClaim("type", "User","Admin"));
   });

// builder.Services.AddControllers();
builder.Services.AddSwaggerGen(c =>
{
   c.SwaggerDoc("v1", new OpenApiInfo { Title = "clothes", Version = "v1" });
   c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
   {
       In = ParameterLocation.Header,
       Description = "Please enter JWT with Bearer into field",
       Name = "Authorization",
       Type = SecuritySchemeType.ApiKey
   });
   c.AddSecurityRequirement(new OpenApiSecurityRequirement {
                { new OpenApiSecurityScheme
                        {
                         Reference = new OpenApiReference { Type = ReferenceType.SecurityScheme, Id = "Bearer"}
                        },
                    new string[] {}
                }
   });
});

// builder.Services.AddControllers()
//     .AddJsonOptions(options =>
//     {
//         options.JsonSerializerOptions.PropertyNamingPolicy = null; // שמות ללא שינוי
//     });

builder.Services.AddControllers();
// builder.Services.AddCloth();
builder.Services.AddSingleton<IclothesService, ShopClothesService>();
builder.Services.AddSingleton<IuserSevice, userService>();
// builder.Services.AddUser();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
var app = builder.Build();

//  app.UselogMiddleware("file.txt");
//  app.UseTokenExpMiddleware();


if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
// builder. builder.Services.AddScoped<ITaskServices, TaskServices>();

app.UseDefaultFiles();

app.UseStaticFiles();

app.UseHttpsRedirection();

app.UseAuthentication();

app.UseAuthorization();

app.MapControllers();

app.Run();
