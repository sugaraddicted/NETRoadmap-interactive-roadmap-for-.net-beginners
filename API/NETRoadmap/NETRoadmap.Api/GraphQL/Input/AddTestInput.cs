using NETRoadmap.Core.Models;

namespace NETRoadmap.Api.GraphQL.Input
{
    public class AddTestInput
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public Guid TopicId { get; set; }
    }
}
