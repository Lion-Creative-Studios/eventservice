using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Presentation.Services;

namespace Presentation.Controllers;

[Route("api/[controller]")]
[ApiController]
public class EventsController(IEventService eventService) : ControllerBase
{
    private readonly IEventService _eventService = eventService;

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var result = await _eventService.GetAllEventsAsync();
        return result != null ? Ok(result) : NotFound();
    }


    [HttpGet("{id}")]
    public async Task<IActionResult> GetEvent(string id)
    {
        var result = await _eventService.GetEventAsync(id);
        return result != null ? Ok(result) : NotFound();
    }
}
