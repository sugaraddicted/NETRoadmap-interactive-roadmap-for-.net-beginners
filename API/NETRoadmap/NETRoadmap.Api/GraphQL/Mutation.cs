using NETRoadmap.Api.GraphQL.Input;
using NETRoadmap.Core.Models;
using NETRoadmap.Infrastructure.Services.Interfaces;

namespace NETRoadmap.Api.GraphQL
{
    public class Mutation
    {
        public async Task<Module> AddModule(AddModuleInput input, [Service] IModuleService moduleService)
        {
            var module = new Module()
            {
                Name = input.Name,
                Description = input.Description,
                IsCompleted = false,
            };

            await moduleService.AddAsync(module);
            return module;
        }

        public async Task<Topic> AddTopic(AddTopicInput input, [Service] ITopicService topicService)
        {
            var topic = new Topic()
            {
                Name = input.Name,
                Description = input.Description,
                ModuleId = input.ModuleId
            };

            await topicService.AddAsync(topic);
            return topic;
        }

        public async Task<Resource> AddResource(AddResourceInput input, [Service] IResourceService resourceService)
        {
            var resource = new Resource()
            {
                Name = input.Name,
                Description = input.Description,
                URL = input.URL,
                TopicId = input.TopicId,
            };

            await resourceService.AddAsync(resource);
            return resource;
        }
    }
}
