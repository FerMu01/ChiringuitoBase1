using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using ChiringuitoDAO.Model;


namespace ChiringuitoDAO.Interfaces
{
    internal interface IBranch : IBase<Branch>
    {
        Branch Get(int idBranch);
    }
}
