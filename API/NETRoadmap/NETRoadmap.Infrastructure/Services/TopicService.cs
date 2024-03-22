using Microsoft.EntityFrameworkCore;
using NETRoadmap.Core.Models;
using NETRoadmap.Infrastructure.Persistence;
using NETRoadmap.Infrastructure.Services.Interfaces;

namespace NETRoadmap.Infrastructure.Services
{
    public class TopicService : EntityBaseRepository<Topic>, ITopicService
    {
        private readonly AppDbContext _context;
        public TopicService(AppDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task<List<Topic>> GetTopicsByModuleIdAsync(Guid moduleId)
        {
            return await _context.Topics.Where(t => t.ModuleId == moduleId).ToListAsync();
        }
    }
}
