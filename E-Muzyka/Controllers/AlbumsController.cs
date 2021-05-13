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
using AutoMapper.QueryableExtensions;
using E_Muzyka.Pagination;

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
        public async Task<IActionResult> Index(string searchString, string currentFilter, int? pageNumber)
        {
            string email = User.Identity.Name;
            AppUser user = _context.Users.FirstOrDefault(u => u.Email == email);
            if (user == null) return null;
            var List = _context.Albums.Where(o => o.AppUser.Id == user.Id).ProjectTo<AlbumDTO>(mapper.ConfigurationProvider);

            if (!String.IsNullOrEmpty(searchString))
            {
                List = List.Where(a => a.Artist.ToLower().Contains(searchString)
                                       || searchString.ToLower().Contains(a.Title.ToLower()) || searchString.Contains(a.Year.ToString()));
            }
            else
            {
                searchString = currentFilter;
            }

            int pageSize = 5;
            return View(await PaginatedList<AlbumDTO>.CreateAsync(List.AsNoTracking(), pageNumber ?? 1, pageSize));
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
            AlbumDTO albumMapped = mapper.Map<AlbumDTO>(album);

            return View(albumMapped);
        }

        public async Task<IActionResult> ShowAlbumsTracks(int? id, string currentFilter, int? pageNumber)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tracks = _context.Tracks.Include(o => o.Album)
                .Where(a => a.AlbumId == id).ProjectTo<TrackDTO>(mapper.ConfigurationProvider);

            if (tracks == null)
            {
                return NotFound();
            }
            int pageSize = 5;
            return View(await PaginatedList<TrackDTO>.CreateAsync(tracks.AsNoTracking(), pageNumber ?? 1, pageSize));
        }
    }
}