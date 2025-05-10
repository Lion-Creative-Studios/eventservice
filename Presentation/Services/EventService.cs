using Microsoft.EntityFrameworkCore;
using Presentation.Data;

namespace Presentation.Services;

public class EventService(DataContext context) : IEventService
{
    private readonly DataContext _context = context;

    public async Task<EventEntity?> GetEventAsync(string eventId)
    {
        var entity = await _context.Events.FirstOrDefaultAsync(x => x.Id == eventId);
        return entity;
    }

    public async Task<List<EventEntity>> GetAllEventsAsync()
    {
        var entities = await _context.Events.ToListAsync();
        return entities;
    }

    /* Lägg till delete och update på en mvp questionable */
}
