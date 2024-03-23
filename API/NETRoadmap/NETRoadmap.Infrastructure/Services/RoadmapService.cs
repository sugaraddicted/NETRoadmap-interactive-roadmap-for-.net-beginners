using NETRoadmap.Core.Models;
using NETRoadmap.Infrastructure.Persistence;
using NETRoadmap.Infrastructure.Services.Interfaces;

namespace NETRoadmap.Infrastructure.Services
{
    public class RoadmapService : EntityBaseRepository<Roadmap>, IRoadmapService
    {
        private readonly AppDbContext _context;
        public RoadmapService(AppDbContext context) : base(context)
        {
            _context = context;
        }
    }
}

