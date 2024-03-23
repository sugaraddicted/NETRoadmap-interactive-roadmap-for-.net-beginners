namespace NETRoadmap.Api.GraphQL.Input
{
    public class AddSubTopicInput
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public Guid TopicId { get; set; }
    }
}
