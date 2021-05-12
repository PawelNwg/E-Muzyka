using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using E_Muzyka.Data;
using E_Muzyka.Models;
using E_Muzyka.ModelDTO;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;

namespace E_Muzyka.Controllers
{
    [Authorize]
    public class TracksController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper mapper;

        public TracksController(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            this.mapper = mapper;
        }

        // GET: Tracks
        public async Task<IActionResult> Index()
        {
            var List = await _context.Tracks.Include(t => t.Album).ToListAsync();
            List<TrackDTO> trackDTO = new List<TrackDTO>();
            foreach (var item in List)
            {
                trackDTO.Add(mapper.Map<TrackDTO>(item));
            }
            return View(trackDTO);
        }

        // GET: Tracks/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var track = await _context.Tracks
                .Include(t => t.Album)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (track == null)
            {
                return NotFound();
            }
            TrackDTO trackMapped = mapper.Map<TrackDTO>(track);
            return View(trackMapped);
        }
    }
}