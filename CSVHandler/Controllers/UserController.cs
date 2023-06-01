using Microsoft.EntityFrameworkCore;

namespace CSVHandler.Controllers;

[ApiController]
[Route("api/[controller]")]
public class UserController : Controller
{
    private readonly CSVContext _ctx;
    private readonly IMapper _mapper;
    public UserController(CSVContext ctx, IMapper mapper) => (_ctx, _mapper) = (ctx, mapper);

    [HttpGet]
    public async Task<IActionResult> GetAllUsers()
    {
        var users = await _ctx.Users.ToListAsync();
        if (!users.Any())
        {
            return NotFound();
        }
        List<User> models = users.Select(u => _mapper.Map<User>(u)).ToList();

        return Ok(models);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id)
    {
        var user = _ctx.Users.FirstOrDefault(u => u.UserId == id);
        if (user is null)
        {
            return NotFound();
        }
        _ctx.Users.Remove(user);
        await _ctx.SaveChangesAsync();

        return Ok();
    }
}
