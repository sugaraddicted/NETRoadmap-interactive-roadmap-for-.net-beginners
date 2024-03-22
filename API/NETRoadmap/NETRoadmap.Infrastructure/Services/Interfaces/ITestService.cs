using NETRoadmap.Core.Models;

namespace NETRoadmap.Infrastructure.Services.Interfaces
{
    public interface ITestService : IEntityBaseRepository<Test>
    {
        Task<Test> GetTestByTopicIdAsync(Guid  topicId);
    }
}
