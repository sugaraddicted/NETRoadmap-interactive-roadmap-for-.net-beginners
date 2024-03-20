
namespace NETRoadmap.Core.Models
{
    public class Answer : IEntityBase
    {
        public Guid Id { get; set; }
        public string AnswerText { get; set; }
        public bool IsCorrect { get; set; }
        public Guid QuestionId { get; set; }
        public Question Question { get; set; }
    }
}
