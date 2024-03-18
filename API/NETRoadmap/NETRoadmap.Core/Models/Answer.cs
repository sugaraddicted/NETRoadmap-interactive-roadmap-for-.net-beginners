﻿
namespace NETRoadmap.Core.Models
{
    public class Answer
    {
        public Guid Id { get; set; }
        public string AnswerText { get; set; }
        public bool IsCorrect { get; set; }
        public Guid QuestionId { get; set; }
        public Question Question { get; set; }
    }
}
