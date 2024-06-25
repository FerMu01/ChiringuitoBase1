using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChiringuitoDAO.Model
{
    public class User : BaseModel
    {
        public short Id { get; set; }
        public string UserName { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string SecondSurname { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime BirthDate { get; set; }
        public string Role { get; set; }
        /// <summary>
        /// Insert
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="name"></param>
        /// <param name="lastName"></param>
        /// <param name="secondSurname"></param>
        /// <param name="email"></param>
        /// <param name="password"></param>
        /// <param name="birthDate"></param>
        /// <param name="role"></param>
        public User(string userName, string name, string lastName, string secondSurname, string email, string password, DateTime birthDate, string role)
        {
            UserName = userName;
            Name = name;
            LastName = lastName;
            SecondSurname = secondSurname;
            Email = email;
            Password = password;
            BirthDate = birthDate;
            Role = role;
        }
        /// <summary>
        /// Get
        /// </summary>
        /// <param name="id"></param>
        /// <param name="userName"></param>
        /// <param name="name"></param>
        /// <param name="lastName"></param>
        /// <param name="secondSurname"></param>
        /// <param name="email"></param>
        /// <param name="password"></param>
        /// <param name="birthDate"></param>
        /// <param name="role"></param>
        /// <param name="status"></param>
        /// <param name="registerDate"></param>
        /// <param name="lastUpdate"></param>
        /// <param name="userID"></param>
        public User(short id, string userName, string name, string lastName, string secondSurname, string email, string password, DateTime birthDate, string role, byte status, DateTime registerDate, DateTime lastUpdate, short userID)
                    : base(status, registerDate, lastUpdate, userID)

        {
            Id = id;
            UserName = userName;
            Name = name;
            LastName = lastName;
            SecondSurname = secondSurname;
            Email = email;
            Password = password;
            BirthDate = birthDate;
            Role = role;
        }
    }
}