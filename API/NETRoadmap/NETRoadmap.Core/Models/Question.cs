
namespace NETRoadmap.Core.Models
{
    public class Question
    {
        public Guid Id { get; set; }
        public string QuestionText { get; set; }
        public List<Answer> Variants { get; set; }
        public Guid TestId { get; set; }
        public Test Test { get; set; }
    }
}
