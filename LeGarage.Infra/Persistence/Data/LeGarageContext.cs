using LeGarage.Core.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace LeGarage.Infra.Persistence.Data
{
    public class LeGarageContext : IdentityDbContext<Employee>
    {
    }
}
