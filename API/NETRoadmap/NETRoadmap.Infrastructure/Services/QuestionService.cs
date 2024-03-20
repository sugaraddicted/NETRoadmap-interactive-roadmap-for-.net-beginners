using NETRoadmap.Core.Models;
using NETRoadmap.Infrastructure.Persistence;

namespace NETRoadmap.Infrastructure.Services
{
    public class QuestionService : EntityBaseRepository<Question>
    {
        public QuestionService(AppDbContext context) : base(context)
        {
        }
    }
}
