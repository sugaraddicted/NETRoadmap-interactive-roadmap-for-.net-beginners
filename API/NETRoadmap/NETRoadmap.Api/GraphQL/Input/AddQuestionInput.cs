using NETRoadmap.Core.Models;

namespace NETRoadmap.Api.GraphQL.Input
{
    public class AddQuestionInput
    {
        public string QuestionText { get; set; }
        public Guid TestId { get; set; }
        public List<AnswerInput> Variants { get; set; }
    }
}
