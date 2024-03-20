using NETRoadmap.Core.Models;
using NETRoadmap.Infrastructure.Persistence;

namespace NETRoadmap.Infrastructure.Services
{
    public class ModuleService : EntityBaseRepository<Module>
    {
        public ModuleService(AppDbContext context) : base(context)
        {
        }
    }
}
