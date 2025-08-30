
using Lineage2DataBaseImporter.Services.Abstractions;
using Lineage2DataBaseImporter.Services.Services;

namespace Lineage2DataBaseImporter
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
            builder.Services.AddOpenApi();
            builder.Services.AddSwaggerGen();

            builder.Services.AddScoped<ISkillReaderService, SkillReaderService>();

            // configure options appsettings.json
            builder.Services.Configure<ImporterOptions>
                (builder.Configuration.GetSection("ImporterOptions"));

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.MapOpenApi();
            }

            app.UseSwagger();
            app.UseSwaggerUI();
            app.MapControllers();
            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
