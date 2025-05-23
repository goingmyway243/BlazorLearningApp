using BlazorLearningApp.Data;
using BlazorLearningApp.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BlazorLearningApp.Controllers;

[Route("api/[controller]")]
[ApiController]
public class SpecialsController : Controller
{
    private readonly PizzaStoreContext _dbContext;

    public SpecialsController(PizzaStoreContext dbContext)
    {
        _dbContext = dbContext;
    }

    [HttpGet]
    public async Task<ActionResult<List<PizzaSpecial>>> GetSpecials()
    {
        return (await _dbContext.Specials.ToListAsync()).OrderByDescending(x => x.BasePrice).ToList();
    }
}
