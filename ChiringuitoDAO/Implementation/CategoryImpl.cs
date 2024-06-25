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
    public class CategoryImpl : BaseImpl, ICategory
    {
        string query;
        public int Delete(Category t)
        {
            query = @"UPDATE Category SET status=0, lastUpdate= CURRENT_TIMESTAMP, userID=@userID
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

        public Category Get(byte id)
        {

            Category t = null;
            query = @"SELECT id, name, description, discount, status, registerDate, ISNULL (lastUpdate, CURRENT_TIMESTAMP), userID
                     FROM Category
                     WHERE id=@id";
            SqlCommand command = CreateBasicCommand(query);
            command.Parameters.AddWithValue("@id", id);
            try
            {
                DataTable Table = ExecuteDataTableCommand(command);
                if (Table.Rows.Count > 0)
                {
                    t = new Category(
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

        public int Insert(Category t)
        {
            query = @"INSERT INTO Category(name , description, discount, userID)
                      VALUES (@name , @description, @discount, @userID)";
            SqlCommand command = CreateBasicCommand(query);
            command.Parameters.AddWithValue("@name", t.Name);
            command.Parameters.AddWithValue("@description", t.Description);
            command.Parameters.AddWithValue("@discount", t.Discount);
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
            query = @"SELECT id, name AS 'Nombre Categoria', description AS 'Descripcion', discount AS 'Descuento'
                      FROM Category
                      WHERE status=1
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

        public int Update(Category t)
        {

            query = @" UPDATE Category SET name=@name, description=@description, discount=@discount, lastUpdate= CURRENT_TIMESTAMP, userID=@userID
                      WHERE id=@id";
            SqlCommand command = CreateBasicCommand(query);
            command.Parameters.AddWithValue("@id", t.Id);
            command.Parameters.AddWithValue("@name", t.Name);
            command.Parameters.AddWithValue("@description", t.Description);
            command.Parameters.AddWithValue("@discount", t.Discount);
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
