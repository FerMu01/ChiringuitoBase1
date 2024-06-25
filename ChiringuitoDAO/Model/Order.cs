using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChiringuitoDAO.Model
{
    public class Order:BaseModel
    {
        public byte Id { get; set; }
        public string Name { get; set; }
        public decimal Total { get; set; }
        /// <summary>
        /// Insert
        /// </summary>
        /// <param name="name"></param>
        /// <param name="total"></param>
        public Order(string name, decimal total)
        {
            Name = name;
            Total = total;
        }
        /// <summary>
        /// Get
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="total"></param>
        /// <param name="status"></param>
        /// <param name="registerDate"></param>
        /// <param name="lastUpdate"></param>
        /// <param name="userID"></param>

        public Order(byte id, string name, decimal total, byte status, DateTime registerDate, DateTime lastUpdate, short userID)
            :base(status, registerDate, lastUpdate, userID)
        {
            Id = id;
            Name = name;
            Total = total;
        }
    }
}
