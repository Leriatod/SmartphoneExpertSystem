using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PhoneExp.Controllers.Dtos;
using PhoneExp.Data;
using PhoneExp.Data.Models;

namespace PhoneExp.Controllers
{
    public class FeatureTypesController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IMapper _mapper;
        public FeatureTypesController(AppDbContext context, IMapper mapper)
        {
            this._mapper = mapper;
            this._context = context;
        }

        [Route("/api/featuretypes")]
        public async Task<IActionResult> GetAsync()
        {
            var featureTypes = await _context.FeatureTypes
                .Include(ft => ft.Features)
                .ToListAsync();
            return Ok(_mapper.Map<List<FeatureType>, List<FeatureTypeDto>>(featureTypes));
        }
    }
}