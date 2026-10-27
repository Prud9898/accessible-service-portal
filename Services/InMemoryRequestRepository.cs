using AccessibleServicePortal.Models;

namespace AccessibleServicePortal.Services;

public class InMemoryRequestRepository : IRequestRepository
{
    private readonly List<ServiceRequest> _requests = new();
    private readonly object _sync = new();
    private int _nextId = 1;

    public IReadOnlyList<ServiceRequest> GetAll()
    {
        lock (_sync) return _requests.OrderByDescending(r => r.CreatedUtc).ToList();
    }

    public ServiceRequest Add(ServiceRequest request)
    {
        lock (_sync)
        {
            request.Id = _nextId++;
            request.CreatedUtc = DateTime.UtcNow;
            _requests.Add(request);
            return request;
        }
    }
}
