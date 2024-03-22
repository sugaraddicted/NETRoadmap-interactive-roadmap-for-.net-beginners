using NETRoadmap.Core.Models;

namespace NETRoadmap.Infrastructure.Services.Interfaces
{
    public interface ITopicService : IEntityBaseRepository<Topic>
    {
        Task<List<Topic>> GetTopicsByModuleIdAsync(Guid moduleId);
    }
}
