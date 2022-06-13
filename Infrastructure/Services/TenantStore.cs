using Core.Entities;
using Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Services
{
    public class TenantStore : ITenantStore
    {
        public Tenant GetTenant(string tenandId)
        {
            return tenandId switch
            {
                "tenant1" => new("" + tenandId + "-"+ "Tenant 1"),
                "tenant2" => new("" + tenandId + "-"+ "Tenant 2"),
                _ => null
            };
        }
    }
}
