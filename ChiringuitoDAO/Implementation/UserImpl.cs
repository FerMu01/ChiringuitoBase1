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
    public class UserImpl :BaseImpl, IUser
    {
        string query;
        public int Delete(User t)
        {
            query = @"UPDATE [User] SET status=0, lastUpdate= CURRENT_TIMESTAMP, userID=@userID
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

        public User Get(short id)
        {
            User t = null;
            query = @"SELECT id, userName, name, lastName, ISNULL (secondSurname, ' '), email, password, birthDate, role,status, registerDate, ISNULL (lastUpdate, CURRENT_TIMESTAMP), userID
                     FROM [User]
                     WHERE id=@id";
            SqlCommand command = CreateBasicCommand(query);
            command.Parameters.AddWithValue("@id", id);
            try
            {
                DataTable Table = ExecuteDataTableCommand(command);
                if (Table.Rows.Count > 0)
                {
                    t = new User(
                        short.Parse(Table.Rows[0][0].ToString()),
                        Table.Rows[0][1].ToString(),
                        Table.Rows[0][2].ToString(),
                        Table.Rows[0][3].ToString(),
                        Table.Rows[0][4].ToString(),
                        Table.Rows[0][5].ToString(),
                        Table.Rows[0][6].ToString(),
                        DateTime.Parse(Table.Rows[0][7].ToString()),
                        Table.Rows[0][8].ToString(),
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

        public int Insert(User t)
        {
            query = @"INSERT INTO [User] (userName, name, lastName, secondSurname, email, password, birthDate, role, userID)
                      VALUES (@userName, @name, @lastName, @secondSurname, @email, HASHBYTES('MD5', @password), @birthDate, @role, @userID)";
            SqlCommand command = CreateBasicCommand(query);
            command.Parameters.AddWithValue("@userName", t.UserName);
            command.Parameters.AddWithValue("@name", t.Name);
            command.Parameters.AddWithValue("@lastName", t.LastName);
            command.Parameters.AddWithValue("@secondSurname", t.SecondSurname);
            command.Parameters.AddWithValue("@email", t.Email);
            command.Parameters.AddWithValue("@password", t.Password).SqlDbType=SqlDbType.VarChar;
            command.Parameters.AddWithValue("@birthDate", t.BirthDate);
            command.Parameters.AddWithValue("@role", t.Role);
            command.Parameters.AddWithValue("@userID", 1);
            try
            {
                return ExecuteBasicCommand(command);
            }
            catch (Exception ex)
            {
                throw ex;
            };
        }

        public DataTable Login(string username, string password)
        {
            query = @" SELECT id, userName, role
                    FROM [User]
                    WHERE status=1 AND userName= @userName AND password= HASHBYTES('MD5', @password)";
            SqlCommand command = CreateBasicCommand(query);
            command.Parameters.AddWithValue("@userName", username);
            command.Parameters.AddWithValue("@password", password).SqlDbType=SqlDbType.VarChar;
            try
            { 
                return ExecuteDataTableCommand(command);
            }catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable Select()
        {
            query = @"SELECT id, userName AS 'Nombre Usuario', name AS 'Nombre', lastName AS 'Primer Apellido', secondSurname AS 'Segundo Apellido', email AS 'Correo Electronico', birthDate AS 'Fecha De Nacimiento', role AS Rol
                      FROM [User]
                      WHERE status=1
                      ORDER BY 4";
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

        public DataTable SelectLikeName(string name)
        {
            throw new NotImplementedException();
        }

        public int Update(User t)
        {
            query = @"UPDATE [User] SET name=@name, lastName=@lastName, secondSurname=@secondName, email=@email, birthDate=@birthDate, lastUpdate= CURRENT_TIMESTAMP, userID=@userID
                      WHERE id=@id";
            SqlCommand command = CreateBasicCommand(query);
            command.Parameters.AddWithValue("@id", t.Id);
            command.Parameters.AddWithValue("@name", t.Name);
            command.Parameters.AddWithValue("@lastName", t.LastName);
            command.Parameters.AddWithValue("@secondName", t.SecondSurname);
            command.Parameters.AddWithValue("@email", t.Email);
            command.Parameters.AddWithValue("@birthDate", t.BirthDate);
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
