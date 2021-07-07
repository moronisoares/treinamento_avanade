using Avanade.SubTCSE.Projeto.Domain.Base.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avanade.SubTCSE.Projeto.Domain.Aggregates.EmployeeRole.Interfaces.Repository
{
    public interface IEmployeeRoleRepository : IBaseRepository<Entities.EmployeeRole, string>
    {
    }
}
