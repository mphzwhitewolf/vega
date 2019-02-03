using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using vega.Models;
using vega.Persistence;

namespace vega.Controllers
{
    public class FeaturesController : Controller
    {

         private readonly VegaDbContext context;
        private readonly IMapper mapper;

        public FeaturesController (VegaDbContext context, IMapper mapper) {
            this.mapper = mapper;
            this.context = context;
        }

        [HttpGet ("/api/features")]
        public async Task<IEnumerable<Features>> GetFeatures () {
            var makes = await context.Makes.Include (m => m.Models).ToListAsync ();
            
            return mapper.Map<List<Make>, List<Features>>(makes);
            // return context.Features;
        }
    }
}