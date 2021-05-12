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
    public class AlbumsController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper mapper;

        public AlbumsController(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            this.mapper = mapper;
        }

        // GET: Albums
        public async Task<IActionResult> Index(string searchString)
        {
            string email = User.Identity.Name;
            AppUser user = _context.Users.FirstOrDefault(u => u.Email == email);
            if (user == null) return null;
            var List = await _context.Albums.Where(o => o.AppUserId == user.Id).ToListAsync();
            if (!String.IsNullOrEmpty(searchString))
            {
                List = List.Where(a => searchString.Contains(a.Artist)
                                       || searchString.Contains(a.Title) || searchString.Contains(a.Year.ToString())).ToList();
            }

            List<AlbumDTO> albumDTO = new List<AlbumDTO>();
            foreach (var item in List)
            {
                albumDTO.Add(mapper.Map<AlbumDTO>(item));
            }

            return View(albumDTO);
        }

        // GET: Albums/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var album = await _context.Albums
                .FirstOrDefaultAsync(m => m.Id == id);
            if (album == null)
            {
                return NotFound();
            }

            return View(album);
        }

        public async Task<IActionResult> ShowAlbumsTracks(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tracks = await _context.Tracks
                .Where(a => a.AlbumId == id).ToListAsync();

            if (tracks == null)
            {
                return NotFound();
            }

            List<TrackDTO> trackDTO = new List<TrackDTO>();
            foreach (var item in tracks)
            {
                trackDTO.Add(mapper.Map<TrackDTO>(item));
            }

            return View(trackDTO);
        }

        private bool AlbumExists(int id)
        {
            return _context.Albums.Any(e => e.Id == id);
        }
    }
}