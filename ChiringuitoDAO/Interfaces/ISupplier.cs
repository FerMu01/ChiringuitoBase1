using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChiringuitoDAO.Model;


namespace ChiringuitoDAO.Interfaces
{
    internal interface ISupplier:IBase<Supplier>
    {
        Supplier Get(byte id);
    }
}
