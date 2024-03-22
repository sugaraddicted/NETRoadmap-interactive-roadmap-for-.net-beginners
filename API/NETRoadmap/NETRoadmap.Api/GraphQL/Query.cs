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
    }
}
