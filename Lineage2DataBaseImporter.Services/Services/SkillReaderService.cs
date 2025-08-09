using Lineage2DataBaseImporter.Services.Abstractions;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lineage2DataBaseImporter.Services.Services
{
    internal class SkillReaderService : IHostedService
    {/// <summary>
     ///     
     /// </summary>
        readonly ImporterOptions _options;
        public SkillReaderService( IOptions<ImporterOptions> options)
        {
            _options = options.Value ?? throw new ArgumentNullException(nameof(options));
        }
        
        
        public async Task StartAsync(CancellationToken cancellationToken)
        {
            // прочитать файлы в папке для чтения 
            var files = Directory.GetFiles(_options.ContentPath, "*.xml", SearchOption.AllDirectories);
            if (files.Length == 0)
            {
               return;
            }
            
            // прочитать по очереди 
            foreach (var file in files)
            {
                try
                {
                    // прочитать файл
                    var text = await File.ReadAllTextAsync(file, cancellationToken);
                }
                catch (Exception ex)
                {
                    // логировать ошибку чтения файла
                    Console.WriteLine($"Error reading file {file}: {ex.Message}");
                }
            }
            // отправить в DataBase по OpenAPI


            throw new NotImplementedException();
        }

        public Task StopAsync(CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
