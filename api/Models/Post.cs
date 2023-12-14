using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
  [Table("posts")]
  public class Post
  {
    [Column("id")]
    public int Id { get; set; }

    [Column("title")]
    public required string Title { get; set; }

    [Column("body")]
    public required string Body { get; set; }

    [Column("tags")]
    public required string[] Tags { get; set; }

    [Column("author")]
    public required string Author { get; set; }
  }
}