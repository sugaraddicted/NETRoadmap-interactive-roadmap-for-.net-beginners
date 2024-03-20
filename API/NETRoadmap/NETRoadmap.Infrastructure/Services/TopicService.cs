using NETRoadmap.Core.Models;
using NETRoadmap.Infrastructure.Persistence;

namespace NETRoadmap.Infrastructure.Services
{
    public class TopicService : EntityBaseRepository<Topic>
    {
        public TopicService(AppDbContext context) : base(context)
        {
        }
    }
}
