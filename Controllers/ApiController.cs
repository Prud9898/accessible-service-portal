using AccessibleServicePortal.Services;
using Microsoft.AspNetCore.Mvc;

namespace AccessibleServicePortal.Controllers;

[ApiController]
[Route("api/requests")]
public class ApiController : ControllerBase
{
    private readonly IRequestRepository _repository;
    public ApiController(IRequestRepository repository) => _repository = repository;

    [HttpGet]
    public IActionResult Get() => Ok(_repository.GetAll().Select(r => new
    {
        r.Id, r.Category, r.CreatedUtc
    }));
}
