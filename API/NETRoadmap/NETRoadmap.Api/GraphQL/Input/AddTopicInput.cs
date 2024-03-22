namespace NETRoadmap.Api.GraphQL.Input
{
    public class AddTopicInput
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public Guid ModuleId { get; set; }
    }
}
