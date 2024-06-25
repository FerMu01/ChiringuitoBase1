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
    public class BranchImpl : BaseImpl, IBranch
    {
        string query;
        public int Delete(Branch t)
        {
            query = @"UPDATE Branch SET status=0, lastUpdate= CURRENT_TIMESTAMP, userID=@userID
                      WHERE idBranch=@idBranch";
            SqlCommand command = CreateBasicCommand(query);
            command.Parameters.AddWithValue("@userID", 1);
            command.Parameters.AddWithValue("@idBranch", t.IdBranch);
            try
            {
                return ExecuteBasicCommand(command);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Branch Get(int idBranch)
        {
            Branch t = null;
            query = @"SELECT idBranch, name , adress ,latitude, longitude, numberContact, image, idCity, idTipe, status, registerDate, ISNULL (lastUpdate, CURRENT_TIMESTAMP), userID 
              FROM Branch
              WHERE idBranch = @idBranch";
            SqlCommand command = CreateBasicCommand(query);
            command.Parameters.AddWithValue("@idBranch", idBranch);
            try
            {
                DataTable Table = ExecuteDataTableCommand(command);
                if (Table.Rows.Count > 0)
                {
                    t = new Branch(
                        int.Parse(Table.Rows[0][0].ToString()),
                        Table.Rows[0][1].ToString(),
                        Table.Rows[0][2].ToString(),
                        double.Parse(Table.Rows[0][3].ToString()),
                        double.Parse(Table.Rows[0][4].ToString()),
                        Table.Rows[0][5].ToString(),
                        Table.Rows[0][6].ToString(), // Nueva línea
                        byte.Parse(Table.Rows[0][7].ToString()),
                        byte.Parse(Table.Rows[0][8].ToString()),
                        byte.Parse(Table.Rows[0][9].ToString()),
                        DateTime.Parse(Table.Rows[0][10].ToString()),
                        DateTime.Parse(Table.Rows[0][11].ToString()),
                        short.Parse(Table.Rows[0][12].ToString())
                    );
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return t;
        }


        public int Insert(Branch t)
        {
            query = @"INSERT INTO Branch (name, adress, latitude, longitude, numberContact, image, idCity, idTipe, userID)
              VALUES (@name, @adress, @latitude, @longitude, @numberContact, @image, @idCity, @idTipe, @userID)";
            SqlCommand command = CreateBasicCommand(query);
            command.Parameters.AddWithValue("@name", t.Name);
            command.Parameters.AddWithValue("@adress", t.Adress);
            command.Parameters.AddWithValue("@latitude", t.Latitude);
            command.Parameters.AddWithValue("@longitude", t.Longitude);
            command.Parameters.AddWithValue("@numberContact", t.NumberContact);
            command.Parameters.AddWithValue("@image", t.Image); // Nueva línea
            command.Parameters.AddWithValue("@idCity", t.IdCity);
            command.Parameters.AddWithValue("@idTipe", t.IdTipe);
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

        public DataTable Select()
        {
            query = @"SELECT idBranch, name AS 'Nombre De Sucursal', adress AS 'Direccion Sucursal', numberContact AS 'Numero De Contacto'
                      FROM Branch
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

        public int Update(Branch t)
        {
            query = @"UPDATE Branch SET name=@name, adress=@adress, latitude=@latitude, longitude=@longitude, 
              numberContact=@numberContact, image=@image, idCity=@idCity, idTipe=@idTipe, 
              lastUpdate= CURRENT_TIMESTAMP, userID=@userID
              WHERE idBranch=@idBranch";
            SqlCommand command = CreateBasicCommand(query);
            command.Parameters.AddWithValue("@idBranch", t.IdBranch);
            command.Parameters.AddWithValue("@name", t.Name);
            command.Parameters.AddWithValue("@adress", t.Adress);
            command.Parameters.AddWithValue("@latitude", t.Latitude);
            command.Parameters.AddWithValue("@longitude", t.Longitude);
            command.Parameters.AddWithValue("@numberContact", t.NumberContact);
            command.Parameters.AddWithValue("@image", t.Image); // Nueva línea
            command.Parameters.AddWithValue("@idCity", t.IdCity);
            command.Parameters.AddWithValue("@idTipe", t.IdTipe);
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
