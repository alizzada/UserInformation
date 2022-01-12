using Microsoft.EntityFrameworkCore;
using UserInformation.Business;
using UserInformation.Business.Abstract;
using UserInformation.DataAccess;
using UserInformation.DataAccess.Abstract;
using UserInformation.DataAccess.Concrete;
using UserInformation.DataAccess.Settings;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddCors(opt =>
{
    opt.AddDefaultPolicy(builder =>
    {
        builder.AllowAnyOrigin()
            .AllowAnyHeader()
            .AllowAnyMethod();
    });
});

AppSettings.ConnectionString = builder.Configuration.GetSection("ConnectionStrings")["UserInfoConString"];

builder.Services.AddDbContext<UserInformationDbContext>(option => option.UseSqlServer(AppSettings.ConnectionString));

builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<IUserService, UserManager>();

var app = builder.Build();
app.UseCors();

app.MapControllers();


app.Run();
