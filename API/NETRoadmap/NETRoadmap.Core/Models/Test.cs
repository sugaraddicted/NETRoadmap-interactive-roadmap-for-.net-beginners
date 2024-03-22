
namespace NETRoadmap.Core.Models
{
    public class Test : IEntityBase
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Score { get; set; }
        public Guid TopicId { get; set; }
        public Topic Topic { get; set; }
        public List<Question> Questions { get; set; }
    }
}
