using Microsoft.AspNetCore.Mvc;

namespace dotnet_core_api_w_postgres.Controllers;

[ApiController]
[Route("[controller]")]
public class PingController : Controller
{
    [HttpGet]
    public IActionResult Index()
    {
        return View();
    }
}