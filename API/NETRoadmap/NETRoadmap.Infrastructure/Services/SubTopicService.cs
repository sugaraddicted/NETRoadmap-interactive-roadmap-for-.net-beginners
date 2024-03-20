using NETRoadmap.Core.Models;
using NETRoadmap.Infrastructure.Persistence;

namespace NETRoadmap.Infrastructure.Services
{
    public class SubTopicService : EntityBaseRepository<SubTopic>
    {
        public SubTopicService(AppDbContext context) : base(context)
        {
        }
    }
}
