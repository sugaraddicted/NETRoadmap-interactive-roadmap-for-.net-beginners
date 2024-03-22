using NETRoadmap.Core.Models;

namespace NETRoadmap.Infrastructure.Services.Interfaces
{
    public interface ISubResourceService : IEntityBaseRepository<SubResource>
    {
        Task<List<SubResource>> GetResourcesByTopicIdAsync(Guid topicId);
    }
}
