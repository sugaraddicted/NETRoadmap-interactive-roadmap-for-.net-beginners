using Microsoft.EntityFrameworkCore;
using NETRoadmap.Api.GraphQL;
using NETRoadmap.Infrastructure.Persistence;
using NETRoadmap.Infrastructure.Services;
using NETRoadmap.Infrastructure.Services.Interfaces;

var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("Postgres");

builder.Services.AddDbContextPool<AppDbContext>(options =>
{
    options.UseNpgsql(connectionString,
        b => b.MigrationsAssembly("NETRoadmap.Infrastructure"));
});

builder.Services.AddTransient<IAnswerService, AnswerService>();
builder.Services.AddTransient<IModuleService, ModuleService>();
builder.Services.AddTransient<IQuestionService, QuestionService>();
builder.Services.AddTransient<IResourceService, ResourceService>();
builder.Services.AddTransient<ISubResourceService, SubResourceService>();
builder.Services.AddTransient<ISubTopicService, SubTopicService>();
builder.Services.AddTransient<ITopicService, TopicService>();
builder.Services.AddTransient<ITestService, TestService>();


builder.Services.AddGraphQLServer()
    .AddMutationConventions()
    .AddQueryType<Query>()
    .AddMutationType<Mutation>();

var app = builder.Build();

app.MapGet("/", () => "Hello World!");
app.MapGraphQL();
app.Run();
