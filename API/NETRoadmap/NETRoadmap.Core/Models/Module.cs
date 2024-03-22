
namespace NETRoadmap.Core.Models
{
    public class Module : IEntityBase
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsCompleted { get; set; }
        public List<Topic> Topics { get; set; }
    }
}
