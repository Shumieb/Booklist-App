namespace BookList.Models;

public class BookDetails
{
    public int Id { get; set; }
    public string? Title { get; set; }
    public int StatusID { get; set; }
    public int AuthorId { get; set; }
    public string? Note { get; set; }
    public string? Summary { get; set; }
    public int Rating { get; set; }
    public string? ImageUrI { get; set; }
}
