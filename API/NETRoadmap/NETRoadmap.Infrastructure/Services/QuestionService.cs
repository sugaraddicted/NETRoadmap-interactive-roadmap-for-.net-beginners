using Microsoft.EntityFrameworkCore;
using NETRoadmap.Core.Models;
using NETRoadmap.Infrastructure.Persistence;
using NETRoadmap.Infrastructure.Services.Interfaces;

namespace NETRoadmap.Infrastructure.Services
{
    public class QuestionService : EntityBaseRepository<Question>, IQuestionService
    {
        private readonly AppDbContext _context;
        public QuestionService(AppDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task<List<Question>> GetQuestionsByTestIdAsync(Guid testId)
        {
            return await _context.Questions.Where(q => q.TestId == testId)
                .Include(q => q.Variants).ToListAsync();
        }
    }
}
