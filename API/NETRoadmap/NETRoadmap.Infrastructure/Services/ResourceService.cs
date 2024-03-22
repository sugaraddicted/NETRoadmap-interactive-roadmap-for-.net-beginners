using Microsoft.EntityFrameworkCore;
using NETRoadmap.Core.Models;
using NETRoadmap.Infrastructure.Persistence;
using NETRoadmap.Infrastructure.Services.Interfaces;

namespace NETRoadmap.Infrastructure.Services
{
    public class ResourceService : EntityBaseRepository<Resource>, IResourceService
    {
        private readonly AppDbContext _context;
        public ResourceService(AppDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task<List<Resource>> GetResourcesByTopicIdAsync(Guid topicId)
        {
            return await _context.Resources.Where(r => r.TopicId == topicId).ToListAsync();
        }
    }
}
