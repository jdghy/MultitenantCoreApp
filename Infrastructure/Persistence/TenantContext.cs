using Core.Entities;
using Core.Interfaces;

namespace Infrastructure.Persistence
{
    public class TenantContext : ITenantContext, ITenantSetter
    {
        public Tenant CurrentTenant { get; set; }
    }
}
