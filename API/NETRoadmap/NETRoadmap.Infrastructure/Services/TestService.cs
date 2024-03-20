using NETRoadmap.Core.Models;
using NETRoadmap.Infrastructure.Persistence;

namespace NETRoadmap.Infrastructure.Services
{
    public class TestService : EntityBaseRepository<Test>
    {
        public TestService(AppDbContext context) : base(context)
        {
        }
    }
}
