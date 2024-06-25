using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChiringuitoDAO.Model;


namespace ChiringuitoDAO.Interfaces
{
    internal interface ICategory:IBase<Category>
    {
       Category Get(byte id);
    }
}
