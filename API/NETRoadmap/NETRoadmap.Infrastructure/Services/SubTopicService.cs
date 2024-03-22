using Microsoft.EntityFrameworkCore;
using NETRoadmap.Core.Models;
using NETRoadmap.Infrastructure.Persistence;
using NETRoadmap.Infrastructure.Services.Interfaces;

namespace NETRoadmap.Infrastructure.Services
{
    public class SubTopicService : EntityBaseRepository<SubTopic>, ISubTopicService
    {
        private readonly AppDbContext _context;
        public SubTopicService(AppDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task<List<SubTopic>> GetSubTopicsByTopicIdAsync(Guid topicId)
        {
            return await _context.SubTopics.Where(st => st.TopicId == topicId).ToListAsync();
        }
    }
}
