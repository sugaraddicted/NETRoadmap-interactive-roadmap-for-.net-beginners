using NETRoadmap.Core.Models;

namespace NETRoadmap.Infrastructure.Services.Interfaces
{ 
    public interface ISubTopicService : IEntityBaseRepository<SubTopic>
    {
        Task<List<SubTopic>> GetSubTopicsByTopicIdAsync(Guid topicId);
    }
}
