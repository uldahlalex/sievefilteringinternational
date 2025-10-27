using Sieve.Models;
using Sieve.Services;

namespace sievefilteringinternational;

public class PostService(MyDbContext ctx, ISieveProcessor sieveProcessor) : IPostService
{
    public async Task<List<Post>> GetPosts(SieveModel sieveModel)
    {
        IQueryable<Post> query = ctx.Posts;

        query =  sieveProcessor.Apply(sieveModel, query);

        return query.ToList();

    }
}