using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Model.Rules
{
    public interface IRoleRepository
    {
        Rule FindBy(Guid id);
        //void Add
    }
}
