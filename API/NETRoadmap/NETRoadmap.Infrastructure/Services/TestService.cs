using Microsoft.EntityFrameworkCore;
using NETRoadmap.Core.Models;
using NETRoadmap.Infrastructure.Persistence;
using NETRoadmap.Infrastructure.Services.Interfaces;

namespace NETRoadmap.Infrastructure.Services
{
    public class TestService : EntityBaseRepository<Test>, ITestService
    {
        private readonly AppDbContext _context;
        public TestService(AppDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task<Test> GetTestByTopicIdAsync(Guid topicId)
        {
            return await _context.Tests.Where(t => t.TopicId == topicId).FirstOrDefaultAsync();
        }
    }
}
