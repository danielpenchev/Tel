using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlFlowCondLoops.Contracts
{
    public interface IVegetable
    {
        bool IsPealed { get; set; }

        bool IsCut { get; set; }

        bool IsRotten { get; set; }
    }
}
