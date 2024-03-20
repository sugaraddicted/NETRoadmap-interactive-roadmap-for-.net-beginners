using NETRoadmap.Core.Models;
using NETRoadmap.Infrastructure.Persistence;

namespace NETRoadmap.Infrastructure.Services
{
    public class AnswerService : EntityBaseRepository<Answer>
    {
        public AnswerService(AppDbContext context) : base(context)
        {
        }
    }
}
