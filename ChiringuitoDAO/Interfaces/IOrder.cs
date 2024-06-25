using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChiringuitoDAO.Model;

namespace ChiringuitoDAO.Interfaces
{
    internal interface IOrder:IBase<Order>
    {
      DataTable SelectLikeName(string name);
    }
}
