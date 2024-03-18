﻿
namespace NETRoadmap.Core.Models
{
    public class Resource
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string URL { get; set; }
        public bool IsCompleted { get; set; }
        public Guid TopicId { get; set; }
        public Topic Topic { get; set; }
    }
}