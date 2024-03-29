﻿
namespace NETRoadmap.Core.Models
{
    public class Topic : IEntityBase
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<SubTopic> SubTopics { get; set; }
        public List<Resource> Resources { get; set; }
        public Guid ModuleId { get; set; }
        public Module Module { get; set; }
        public Test Test { get; set; }
    }
}
