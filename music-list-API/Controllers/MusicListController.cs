using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using music_list_API.Models;

namespace music_list_API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MusicListController : ControllerBase
    {
        #region DECLARATIONS
        private readonly MusicListContext _context;
        private readonly ILogger<MusicListController> _logger;
        #endregion

        #region PROPERTIES / INDEXES
        #endregion

        #region CONSTRUCTORS
        public MusicListController(MusicListContext context, ILogger<MusicListController>logger)
        {
            _context = context;
            _logger = logger;
        }
        #endregion

        #region PUBLIC METHODS
        [HttpPost]
        public async Task<ActionResult<MusicSong>> UploadMusicSong(MusicSong musicSong)
        {
            _context.MusicLists.Add(musicSong);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(UploadMusicSong), new { id = musicSong.Id}, musicSong);
        }
        // TODO: HttpGet
        // TODO: HttpPut
        // TODO: HttpDelete
        #endregion
    }
}