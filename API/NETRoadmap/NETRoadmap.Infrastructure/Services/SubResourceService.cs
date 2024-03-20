using NETRoadmap.Core.Models;
using NETRoadmap.Infrastructure.Persistence;

namespace NETRoadmap.Infrastructure.Services
{
    internal class SubResourceService : EntityBaseRepository<SubResource>
    {
        public SubResourceService(AppDbContext context) : base(context)
        {
        }
    }
}
