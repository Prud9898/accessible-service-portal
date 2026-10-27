using AccessibleServicePortal.Models;

namespace AccessibleServicePortal.Services;

public interface IRequestRepository
{
    IReadOnlyList<ServiceRequest> GetAll();
    ServiceRequest Add(ServiceRequest request);
}
