using Microsoft.EntityFrameworkCore;

namespace music_list_API.Models;

public class MusicListContext : DbContext
{
    public MusicListContext(DbContextOptions<MusicListContext> options) : base (options)
    {

    }
    public DbSet<MusicList> MusicLists { get; set; } = null!;
}