using Lineage2DataBaseImporter.Services.Abstractions;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Lineage2DataBaseImporter.Services.Models.Skills;
using Microsoft.Extensions.Logging;

namespace Lineage2DataBaseImporter.Services.Services
{
    //internal class SkillReaderService : IHostedService
    public class SkillReaderService : ISkillReaderService
    {/// <summary>
     ///     
     /// </summary>
        private readonly ImporterOptions _options;
        private readonly ILogger<SkillReaderService> _logger;
        public SkillReaderService(IOptions<ImporterOptions> options, 
            ILogger<SkillReaderService> logger)
        {
            _options = options.Value ?? throw new ArgumentNullException(nameof(options));
            _logger = logger;
        }


        public async Task StartAsync(CancellationToken cancellationToken)
        {
            // прочитать файлы в папке для чтения 
            var files = Directory.GetFiles(Path.Combine(_options.ContentPath,"skills"), "*.xml", SearchOption.AllDirectories);
            if (files.Length == 0)
            {
                return;
            }

            // прочитать по очереди 
            var list = new List<Skill>();
            foreach (var file in files)
            {
                try
                {
                    // прочитать файл
                    var text = await File.ReadAllTextAsync(file, cancellationToken);
                    // десериализовать
                    var serializer = new XmlSerializer(typeof(SkillList));
                    SkillList? data = (SkillList) serializer.Deserialize(new StringReader(text));
                    if (data is not null)
                        list.AddRange(data.Skill);
                    else
                        _logger.LogWarning("Deserialize return null for file {file}", file);
                        ;
                    //TODO:
                    // 1. Добавить сервис, который будет валидировать DTO
                    // 2. Добавить сервис, который будет конвертировать сырые данные в DTO для отправки в DataBase
                    // 3. Использовать SDL базы знаний для отправки
                }
                catch (Exception ex)
                {
                    // логировать ошибку чтения файла
                    Console.WriteLine($"Error reading file {file}: {ex.Message}");
                }
                ;
            }
            _logger.LogInformation("Total skills read: {count}", list.Count)
            ;
        }

        public Task StopAsync(CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
