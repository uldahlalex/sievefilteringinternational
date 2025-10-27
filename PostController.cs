using Microsoft.AspNetCore.Mvc;
using Sieve.Models;

namespace sievefilteringinternational;

public class PostController(IPostService postService) : ControllerBase
{
    [HttpGet(nameof(GetPosts))]
    public async Task<List<Post>> GetPosts([FromQuery]SieveModel sieveModel)
    {
        return await postService.GetPosts(sieveModel);
    }
}