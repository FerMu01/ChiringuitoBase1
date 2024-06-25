using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChiringuitoDAO.Model
{
    public class Supplier : BaseModel
    {
        public byte Id { get; set; }
        public string Nit { get; set; }
        public string Business { get; set; }
        public string PhoneNumber { get; set; }
        /// <summary>
        /// Insert
        /// </summary>
        /// <param name="nit"></param>
        /// <param name="business"></param>
        /// <param name="phoneNumber"></param>
        public Supplier(string nit, string business, string phoneNumber)
        {
            Nit = nit;
            Business = business;
            PhoneNumber = phoneNumber;
        }
        /// <summary>
        /// Get
        /// </summary>
        /// <param name="id"></param>
        /// <param name="nit"></param>
        /// <param name="business"></param>
        /// <param name="phoneNumber"></param>
        /// <param name="status"></param>
        /// <param name="registerDate"></param>
        /// <param name="lastUpdate"></param>
        /// <param name="userID"></param>
        public Supplier(byte id, string nit, string business, string phoneNumber, byte status, DateTime registerDate, DateTime lastUpdate, short userID)
        : base(status, registerDate, lastUpdate, userID)
        {
            Id = id;
            Nit = nit;
            Business = business;
            PhoneNumber = phoneNumber;
        }
    }
}
