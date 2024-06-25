using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChiringuitoDAO.Interfaces;
using ChiringuitoDAO.Model;

namespace ChiringuitoDAO.Implementation
{
    public class SupplierImpl : BaseImpl, ISupplier
    {
        string query;
        public int Delete(Supplier t)
        {
            query = @"UPDATE Supplier SET status=0, lastUpdate= CURRENT_TIMESTAMP, userID=@userID
                      WHERE id=@id";
            SqlCommand command = CreateBasicCommand(query);
            command.Parameters.AddWithValue("@userID", 1);
            command.Parameters.AddWithValue("@id", t.Id);
            try
            {
                return ExecuteBasicCommand(command);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Supplier Get(byte id)
        {
            Supplier t = null;
            query = @"SELECT id, cinit, business, phoneNumber, status, registerDate, ISNULL (lastUpdate, CURRENT_TIMESTAMP), userID
                     FROM Supplier
                     WHERE id=@id";
            SqlCommand command = CreateBasicCommand(query);
            command.Parameters.AddWithValue("@id", id);
            try
            {
                DataTable Table = ExecuteDataTableCommand(command);
                if (Table.Rows.Count > 0)
                {
                    t = new Supplier(
                        byte.Parse(Table.Rows[0][0].ToString()),
                        Table.Rows[0][1].ToString(),
                        Table.Rows[0][2].ToString(),
                        Table.Rows[0][3].ToString(),
                        byte.Parse(Table.Rows[0][4].ToString()),
                        DateTime.Parse(Table.Rows[0][5].ToString()),
                        DateTime.Parse(Table.Rows[0][6].ToString()),
                        short.Parse(Table.Rows[0][7].ToString())
                    );
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return t;
        }

        public int Insert(Supplier t)
        {
        query= @"INSERT INTO Supplier(cinit , business, phoneNumber, userID)
                      VALUES (@cinit, @business, @phoneNumber, @userID)";
            SqlCommand command = CreateBasicCommand(query);
            command.Parameters.AddWithValue("@cinit", t.Nit);
            command.Parameters.AddWithValue("@business", t.Business);
            command.Parameters.AddWithValue("@phoneNumber", t.PhoneNumber);
            command.Parameters.AddWithValue("@userID", t.UserID);
            try
            {
                return ExecuteBasicCommand(command);
            }
            catch (Exception ex)
            {
                throw ex;
            };
        }

        public DataTable Select()
        {
            query = @"SELECT id, cinit AS NIT, business AS 'Nombre Proveedor', phoneNumber AS 'Numero De Contacto'
                      FROM Supplier
                      WHERE status=1
                      ORDER BY 3";
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

        public int Update(Supplier t)
        {
            query = @"UPDATE Supplier SET cinit=@cinit, business=@business, phoneNumber=@phoneNumber, lastUpdate= CURRENT_TIMESTAMP, userID=@userID
                      WHERE id=@id";
            SqlCommand command = CreateBasicCommand(query);
            command.Parameters.AddWithValue("@id", t.Id);
            command.Parameters.AddWithValue("@cinit", t.Nit);
            command.Parameters.AddWithValue("@business", t.Business);
            command.Parameters.AddWithValue("@phoneNumber", t.PhoneNumber);
            command.Parameters.AddWithValue("@userID", 1);
            try
            {
                return ExecuteBasicCommand(command);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
