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
    public class PhonesController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IMapper _mapper;
        public PhonesController(AppDbContext context, IMapper mapper)
        {
            this._mapper = mapper;
            this._context = context;
        }

        [Route("/api/phones")]
        public async Task<IActionResult> GetAsync()
        {
            var phones = await _context.Phones
                .Include(p => p.Features)
                .ToListAsync();
            return Ok(_mapper.Map<List<Phone>, List<PhoneDto>>(phones));
        }
    }
}