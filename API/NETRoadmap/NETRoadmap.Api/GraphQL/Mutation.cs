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
    }
}
