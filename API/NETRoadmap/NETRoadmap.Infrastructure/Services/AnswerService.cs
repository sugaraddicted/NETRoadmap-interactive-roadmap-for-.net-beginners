using Microsoft.EntityFrameworkCore;
using NETRoadmap.Core.Models;
using NETRoadmap.Infrastructure.Persistence;
using NETRoadmap.Infrastructure.Services.Interfaces;

namespace NETRoadmap.Infrastructure.Services
{
    public class AnswerService : EntityBaseRepository<Answer>, IAnswerService
    {
        private readonly AppDbContext _context;
        public AnswerService(AppDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task<List<Answer>> GetAnswersByQuestionIdAsync(Guid questionId)
        {
            return await _context.Answers.Where(a => a.QuestionId == questionId).ToListAsync();
        }
    }
}
