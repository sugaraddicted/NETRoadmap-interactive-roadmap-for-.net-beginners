
namespace NETRoadmap.Core.Models
{
    public class SubResource : IEntityBase
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string URL { get; set; }
        public bool IsCompleted { get; set; }
        public Guid SubTopicId { get; set; }
        public SubTopic SubTopic { get; set; }
    }
}
