using Core.Entities;

namespace Core.Interfaces
{
    public interface ITenantContext
    {
       Tenant CurrentTenant { get; }
    }
}
