using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeriodicTable.Elements
{
    public interface IAtom
    {
        int Protons { get; }
        int Neutrons { get; }
        int Electrons { get; }
    }
}
