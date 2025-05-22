using Scalar.AspNetCore;
using Microsoft.AspNetCore.OpenApi;
using GrossistenApi.Data;
using Microsoft.EntityFrameworkCore;

namespace GrossistenApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.  
            builder.Services.AddRazorPages();

            builder.Services.AddOpenApi(options =>
            {
                options.AddDocumentTransformer((document, context, _) =>
                {
                    document.Info = new()
                    {
                    };
                    return Task.CompletedTask;
                });
            });
            builder.Services
                .AddControllers()
                .AddXmlSerializerFormatters();

            builder.Services.AddEndpointsApiExplorer();

            builder.Services.AddDbContext<GrossistenApiDatabaseContext>(options =>
                options.UseSqlServer(
                builder.Configuration.GetConnectionString("DefaultConnection")
                )
            );
            var app = builder.Build();


            // Configure the HTTP request pipeline.  
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.  
                app.UseHsts();
            }

            if (app.Environment.IsDevelopment())
            {
                // Map OpenAPI using Scalar.  
                app.MapOpenApi();
                app.MapScalarApiReference();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapRazorPages();

            app.MapGet("/", () => Results.Redirect("/scalar/v1")).ExcludeFromDescription();

            app.MapControllers();

            app.Run();
        }
    }
}
