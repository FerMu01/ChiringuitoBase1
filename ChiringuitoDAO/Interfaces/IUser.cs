using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChiringuitoDAO.Model;

namespace ChiringuitoDAO.Interfaces
{
    internal interface IUser:IBase<User>
    {
        User Get(short id);
        DataTable SelectLikeName(string name);
        DataTable Login(string username, string password);
    }

}
