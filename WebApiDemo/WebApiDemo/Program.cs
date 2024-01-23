using Microsoft.EntityFrameworkCore;
using WebApiDemo.Context;
using WebApiDemo.Interface;
using WebApiDemo.Repository;

namespace WebApiDemo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddControllers();

            builder.Services.AddDbContext<WebDbContext>(options =>
            {
                options.UseSqlServer(builder.Configuration.GetConnectionString("WebConnction"));
    
            });

            builder.Services.AddTransient<ClintInterface , ClintRepository>();
            // Add services to the container.


            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
           // builder.Services.AddEndpointsApiExplorer();
            //builder.Services.AddSwaggerGen();

            var app = builder.Build();

            
            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                //app.UseSwagger();
                //app.UseSwaggerUI();
            }

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}