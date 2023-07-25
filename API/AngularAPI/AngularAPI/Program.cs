using AngularAPI.Authentication;
using AngularAPI.Models;
using AngularAPI.Services.BooingRepo;
using AngularAPI.Services.FeedbackRepo;
using AngularAPI.Services.HotelRepo;
using AngularAPI.Services.UserRepo;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IUsers, UserServices>();
builder.Services.AddScoped<Ihotels, HotelServices>();
builder.Services.AddScoped<IBooking, BookingServices>();
builder.Services.AddScoped<IUserFeedback, UserFeedbackServices>();
builder.Services.AddDbContext<AngularApiContext>(optionsAction: options => options.UseSqlServer(builder.Configuration.GetConnectionString(name: "SQLConnection")));
builder.Services.AddDbContext<DBContext>(optionsAction: options => options.UseSqlServer(builder.Configuration.GetConnectionString(name: "Authorization")));



builder.Services.AddCors(option =>
{
    option.AddPolicy("Policy", builder =>
    {
        builder.AllowAnyHeader();
        builder.AllowAnyMethod();
        builder.AllowAnyOrigin();
    });
});



var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseCors("Policy");
app.UseAuthorization();

app.MapControllers();

app.Run();
