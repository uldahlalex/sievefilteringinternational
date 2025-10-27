using Sieve.Attributes;

namespace sievefilteringinternational;

public class Post
{
    public int Id { get; set; }

    [Sieve(CanFilter = true, CanSort = true)]
    public string Title { get; set; }

    [Sieve(CanFilter = true, CanSort = true)]
    public int LikeCount { get; set; }

    [Sieve(CanFilter = true, CanSort = true)]
    public int CommentCount { get; set; }

    [Sieve(CanFilter = true, CanSort = true, Name = "created")]
    public DateTimeOffset DateCreated { get; set; } = DateTimeOffset.UtcNow;

}