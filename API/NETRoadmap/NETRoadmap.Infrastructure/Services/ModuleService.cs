using NETRoadmap.Core.Models;
using NETRoadmap.Infrastructure.Persistence;
using NETRoadmap.Infrastructure.Services.Interfaces;

namespace NETRoadmap.Infrastructure.Services
{
    public class ModuleService : EntityBaseRepository<Module>, IModuleService
    {
        public ModuleService(AppDbContext context) : base(context)
        {
        }
    }
}
