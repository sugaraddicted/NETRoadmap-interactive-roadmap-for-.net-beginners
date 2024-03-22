using NETRoadmap.Core.Models;

namespace NETRoadmap.Infrastructure.Services.Interfaces
{
    public interface IResourceService : IEntityBaseRepository<Resource>
    {
        Task<List<Resource>> GetResourcesByTopicIdAsync(Guid topicId);
    }
}
