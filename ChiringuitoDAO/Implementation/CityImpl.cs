using ChiringuitoDAO.Interfaces;
using ChiringuitoDAO.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChiringuitoDAO.Implementation
{
    public class CityImpl : BaseImpl, ICity
    {
        string query;
        public int Delete(City t)
        {
            throw new NotImplementedException();
        }

        public int Insert(City t)
        {
            throw new NotImplementedException();
        }

        public DataTable Select()
        {
            query = @"SELECT id, name
                      FROM City
                      ORDER BY 2";
            SqlCommand command = CreateBasicCommand(query);
            try
            {
                return ExecuteDataTableCommand(command);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int Update(City t)
        {
            throw new NotImplementedException();
        }
    }
}
