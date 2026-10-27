using AccessibleServicePortal.Models;
using AccessibleServicePortal.Services;
using Microsoft.AspNetCore.Mvc;

namespace AccessibleServicePortal.Controllers;

public class RequestsController : Controller
{
    private readonly IRequestRepository _repository;
    public RequestsController(IRequestRepository repository) => _repository = repository;

    [HttpGet]
    public IActionResult Index() => View(_repository.GetAll());

    [HttpGet]
    public IActionResult Create() => View(new ServiceRequest());

    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Create(ServiceRequest request)
    {
        if (!new[] { "Accessibility", "Technical support", "General inquiry" }.Contains(request.Category))
            ModelState.AddModelError(nameof(request.Category), "Select a valid request category.");

        if (!ModelState.IsValid) return View(request);

        var saved = _repository.Add(request);
        TempData["Success"] = $"Request {saved.Id} was submitted successfully.";
        return RedirectToAction(nameof(Index));
    }
}
