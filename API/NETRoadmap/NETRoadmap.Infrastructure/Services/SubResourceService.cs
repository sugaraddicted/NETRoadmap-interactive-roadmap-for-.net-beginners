using Microsoft.EntityFrameworkCore;
using NETRoadmap.Core.Models;
using NETRoadmap.Infrastructure.Persistence;
using NETRoadmap.Infrastructure.Services.Interfaces;

namespace NETRoadmap.Infrastructure.Services
{
    internal class SubResourceService : EntityBaseRepository<SubResource>, ISubResourceService
    {
        private readonly AppDbContext _context;
        public SubResourceService(AppDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task<List<SubResource>> GetResourcesByTopicIdAsync(Guid topicId)
        {
            return await _context.SubResources.Where(r => r.SubTopicId == topicId).ToListAsync();
        }
    }
}
