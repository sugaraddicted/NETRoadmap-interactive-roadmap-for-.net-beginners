using NETRoadmap.Api.GraphQL.Input;
using NETRoadmap.Core.Models;
using NETRoadmap.Infrastructure.Services.Interfaces;

namespace NETRoadmap.Api.GraphQL
{
    public class Mutation
    {
        public async Task<Module> AddModule(AddModuleInput input, [Service] IModuleService moduleService)
        {
            var module = new Module()
            {
                Name = input.Name,
                Description = input.Description,
                IsCompleted = false,
            };

            await moduleService.AddAsync(module);
            return module;
        }

        public async Task<Topic> AddTopic(AddTopicInput input, [Service] ITopicService topicService)
        {
            var topic = new Topic()
            {
                Name = input.Name,
                Description = input.Description,
                ModuleId = input.ModuleId
            };

            await topicService.AddAsync(topic);
            return topic;
        }

        public async Task<Resource> AddResource(AddResourceInput input, [Service] IResourceService resourceService)
        {
            var resource = new Resource()
            {
                Name = input.Name,
                Description = input.Description,
                URL = input.URL,
                TopicId = input.TopicId,
            };

            await resourceService.AddAsync(resource);
            return resource;
        }

        public async Task<Test> AddTest(AddTestInput input, [Service] ITestService testService)
        {
            var test = new Test()
            {
                Name = input.Name,
                Description = input.Description,
                TopicId = input.TopicId,
            };

            await testService.AddAsync(test);
            return test;
        }
        public async Task<Question> AddQuestion(AddQuestionInput input, [Service] IQuestionService questionService, [Service] IAnswerService answerService)
        {
            var question = new Question()
            {
                QuestionText = input.QuestionText,
                TestId = input.TestId
            };
            await questionService.AddAsync(question);

            foreach (var answerInput in input.Variants)
            {
                var answer = new Answer()
                {
                    AnswerText = answerInput.AnswerText,
                    IsCorrect = answerInput.IsCorrect,
                    QuestionId = question.Id
                };
                await answerService.AddAsync(answer);
            }

            return question;
        }
    }
}
