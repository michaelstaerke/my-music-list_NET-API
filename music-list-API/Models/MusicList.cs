namespace music_list_API.Models;

public class MusicList
{
    public int Id { get; set; }
    public string? Artist { get; set; }
    public string? Label { get; set; }
    public string? Songname { get; set; }
    public string? Album { get; set; }
    public DateTime ReleaseTime { get; set; }
}