namespace NETRoadmap.Api.GraphQL.Input
{
    public class BaseResourceInput
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string URL { get; set; }
        public bool IsCompleted { get; set; }
    }
}
