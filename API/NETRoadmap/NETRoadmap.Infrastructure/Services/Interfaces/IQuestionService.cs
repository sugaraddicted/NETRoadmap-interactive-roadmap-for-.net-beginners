using NETRoadmap.Core.Models;

namespace NETRoadmap.Infrastructure.Services.Interfaces
{
    public interface IQuestionService : IEntityBaseRepository<Question>
    {
        Task<List<Question>> GetQuestionsByTestIdAsync(Guid testId);
    }
}
