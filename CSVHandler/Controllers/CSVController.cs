namespace CSVHandler.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CSVController : Controller
{
    private readonly ICSVService _csvService;
    private readonly CSVContext _ctx;
    private readonly IMapper _mapper;

    public CSVController(ICSVService csvService, CSVContext ctx, IMapper mapper)
    {
        _csvService = csvService;
        _ctx = ctx;
        _mapper = mapper;
    }

    [HttpPost("read-csv")]
    public IActionResult GetCSV([FromForm] IFormFileCollection file)
    {
        var users = _csvService.ReadCSV<User>(file[0].OpenReadStream());

        List<UserModel> models = users.Select(u => _mapper.Map<UserModel>(u)).ToList();

        _ctx.AddRange(models);
        _ctx.SaveChanges();

        return Ok(users);
    }
}
