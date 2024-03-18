
namespace NETRoadmap.Core.Models
{
    public class Test
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Score { get; set; }
        public Guid SubTopicId { get; set; }
        public SubTopic SubTopic { get; set; }
        public List<Question> Questions { get; set; }
    }
}
