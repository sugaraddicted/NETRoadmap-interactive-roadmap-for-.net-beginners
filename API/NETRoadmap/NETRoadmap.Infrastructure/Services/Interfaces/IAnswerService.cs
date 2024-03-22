using NETRoadmap.Core.Models;

namespace NETRoadmap.Infrastructure.Services.Interfaces
{
    public interface IAnswerService : IEntityBaseRepository<Answer>
    {
        Task<List<Answer>> GetAnswersByQuestionIdAsync(Guid questionId);
    }
}
