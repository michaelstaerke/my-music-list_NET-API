using Microsoft.EntityFrameworkCore;
namespace music_list_API.Models;

public class MusicListContext : DbContext
{
    public MusicListContext(DbContextOptions<MusicListContext> options) : base (options)
    {

    }
    // a list of music songs
    public DbSet<MusicSong> MusicLists { get; set; } = null!;
}