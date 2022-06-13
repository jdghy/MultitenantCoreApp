using Core.Entities;

namespace Core.Interfaces
{
    public interface ITenantSetter
    {
        Tenant CurrentTenant { set; }
    }
}
