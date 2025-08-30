
namespace Lineage2DataBaseImporter.Services.Abstractions
{
    public interface ISkillReaderService
    {
        Task StartAsync(CancellationToken cancellationToken);
    }
}