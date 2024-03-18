
namespace NETRoadmap.Core.Models
{
    public class Module
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<Topic> Topics { get; set; }
    }
}
