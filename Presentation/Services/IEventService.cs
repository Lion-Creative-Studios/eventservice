using Microsoft.EntityFrameworkCore;
using Presentation.Data;

namespace Presentation.Services;

public interface IEventService
{
    Task<List<EventEntity>> GetAllEventsAsync();
    Task<EventEntity?> GetEventAsync(string eventId);
}
