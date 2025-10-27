using Sieve.Models;

namespace sievefilteringinternational;

public interface IPostService
{
    Task<List<Post>> GetPosts(SieveModel sieveModel);
}