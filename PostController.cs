using Microsoft.AspNetCore.Mvc;

namespace sievefilteringinternational;

public class PostController : ControllerBase
{
    [HttpGet(nameof(GetPosts))]
    public async Task<object> GetPosts()
    {
        return new
        {
            result = "that worked"
        };
    }
}