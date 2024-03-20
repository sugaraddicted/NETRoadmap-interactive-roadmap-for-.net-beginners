
namespace NETRoadmap.Core.Models
{
    public class SubTopic : IEntityBase
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Test Test { get; set; }
        public List<SubResource> SubResources { get; set; }
        public Guid TopicId { get; set; }
        public Topic Topic { get; set; }
    }
}
