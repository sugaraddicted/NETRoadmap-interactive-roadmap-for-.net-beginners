using NETRoadmap.Core.Models;
using NETRoadmap.Infrastructure.Services.Interfaces;

namespace NETRoadmap.Api.GraphQL
{
    public class Query
    {
        public async Task<Module> GetModuleById(Guid moduleId, 
            [Service] IModuleService moduleService)
        {
            return await moduleService.GetByIdAsync(moduleId);
        }

        public async Task<Topic> GetTopicById(Guid topicId, 
            [Service] ITopicService topicService)
        {
            return await topicService.GetByIdAsync(topicId);
        }

        public async Task<Resource> GetResourceById(Guid resourceId, 
            [Service] IResourceService resourceService)
        {
            return await resourceService.GetByIdAsync(resourceId);
        }

        public async Task<Test> GetTestById(Guid testId, 
            [Service] ITestService testService)
        {
            return await testService.GetByIdAsync(testId);
        }

        public async Task<List<Topic>> GetTopicsByModuleId(Guid moduleId, 
            [Service] ITopicService topicService)
        {
            return await topicService.GetTopicsByModuleIdAsync(moduleId);
        }

        public async Task<List<SubTopic>> GetSubTopicsByTopicId(Guid topicId, 
            [Service] ISubTopicService subTopicService)
        {
            return await subTopicService.GetSubTopicsByTopicIdAsync(topicId);
        }

        public async Task<Test> GetTestByTopicId(Guid topicId, 
            [Service] ITestService testService)
        {
            return await testService.GetTestByTopicIdAsync(topicId);
        }

        public async Task<List<Question>> GetQuestionsByTestId(Guid testId, 
            [Service] IQuestionService questionService)
        {
            return await questionService.GetQuestionsByTestIdAsync(testId);
        }

        public async Task<List<Resource>> GetResourcesByTopicId(Guid topicId, 
            [Service] IResourceService resourceService)
        {
            return await resourceService.GetResourcesByTopicIdAsync(topicId);
        }
        public async Task<List<SubResource>> GetSubResourcesByTopicId(Guid topicId, 
            [Service] ISubResourceService subResourceService)
        {
            return await subResourceService.GetResourcesByTopicIdAsync(topicId);
        }
    }
}
