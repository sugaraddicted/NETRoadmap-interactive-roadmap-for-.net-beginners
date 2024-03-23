namespace NETRoadmap.Core.Models
{
    public class Roadmap : IEntityBase
    {
        public Guid Id { get; set; }
        public string Name { get; set; }    
        public string Description { get; set; }
        public List<Module> Modules { get; set; }
    }
}
