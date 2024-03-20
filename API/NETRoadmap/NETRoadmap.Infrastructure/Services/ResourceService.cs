using NETRoadmap.Core.Models;
using NETRoadmap.Infrastructure.Persistence;

namespace NETRoadmap.Infrastructure.Services
{
    public class ResourceService : EntityBaseRepository<Resource>
    {
        public ResourceService(AppDbContext context) : base(context)
        {
        }
    }
}
