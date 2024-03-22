using NETRoadmap.Core.Models;
using NETRoadmap.Infrastructure.Services.Interfaces;

namespace NETRoadmap.Api.GraphQL
{
    public class Query
    {
        public async Task<Module> GetModuleById(Guid moduleId, [Service] IModuleService moduleService)
        {
            return await moduleService.GetByIdAsync(moduleId);
        }
        public async Task<Topic> GetTopicById(Guid topicId, [Service] ITopicService topicService)
        {
            return await topicService.GetByIdAsync(topicId);
        }
        public async Task<Resource> GetResourceById(Guid resourceId, [Service] IResourceService resourceService)
        {
            return await resourceService.GetByIdAsync(resourceId);
        }
        public async Task<Test> GetTestById(Guid testId, [Service] ITestService testService)
        {
            return await testService.GetByIdAsync(testId);
        }
    }
}
