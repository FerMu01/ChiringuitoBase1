using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChiringuitoDAO.Model
{
    public class Category:BaseModel
    {
        public byte Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Discount { get; set; }
        /// <summary>
        /// Insert
        /// </summary>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="discount"></param>
        public Category(string name, string description, string discount)
        {
            Name = name;
            Description = description;
            Discount = discount;
        }
        /// <summary>
        /// Get
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="discount"></param>
        /// <param name="status"></param>
        /// <param name="registerDate"></param>
        /// <param name="lastUpdate"></param>
        /// <param name="userID"></param>
        public Category(byte id, string name, string description, string discount, byte status, DateTime registerDate, DateTime lastUpdate, short userID)
        : base(status, registerDate, lastUpdate, userID)
        {
            Id = id;
            Name = name;
            Description = description;
            Discount = discount;
        }
    }
}
