using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChiringuitoDAO.Model
{
    public class Branch : BaseModel
    {
        public int IdBranch { get; set; }
        public string Name { get; set; }
        public string Adress { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public string NumberContact { get; set; }
        public string Image { get; set; }
        public byte IdCity { get; set; }
        public byte IdTipe { get; set; }

        /// <summary>
        /// Insert constructor
        /// </summary>
        /// <param name="name">Branch name</param>
        /// <param name="adress">Branch address</param>
        /// <param name="latitude">Branch latitude</param>
        /// <param name="longitude">Branch longitude</param>
        /// <param name="numberContact">Branch contact number</param>
        /// <param name="imageBase64">Branch image in Base64 format</param>
        /// <param name="idCity">City ID</param>
        /// <param name="idTipe">Type ID</param>
        public Branch(string name, string adress, double latitude, double longitude, string numberContact, string imageBase64, byte idCity, byte idTipe)
        {
            Name = name;
            Adress = adress;
            Latitude = latitude;
            Longitude = longitude;
            NumberContact = numberContact;
            Image = imageBase64;
            IdCity = idCity;
            IdTipe = idTipe;
        }

        /// <summary>
        /// Get constructor
        /// </summary>
        /// <param name="idBranch">Branch ID</param>
        /// <param name="name">Branch name</param>
        /// <param name="adress">Branch address</param>
        /// <param name="latitude">Branch latitude</param>
        /// <param name="longitude">Branch longitude</param>
        /// <param name="numberContact">Branch contact number</param>
        /// <param name="image">Branch image in Base64 format</param>
        /// <param name="idCity">City ID</param>
        /// <param name="idTipe">Type ID</param>
        /// <param name="status">Branch status</param>
        /// <param name="registerDate">Register date</param>
        /// <param name="lastUpdate">Last update date</param>
        /// <param name="userID">User ID</param>
        public Branch(int idBranch, string name, string adress, double latitude, double longitude, string numberContact, string image, byte idCity, byte idTipe, byte status, DateTime registerDate, DateTime lastUpdate, short userID)
            : base(status, registerDate, lastUpdate, userID)
        {
            IdBranch = idBranch;
            Name = name;
            Adress = adress;
            Latitude = latitude;
            Longitude = longitude;
            NumberContact = numberContact;
            Image = image;
            IdCity = idCity;
            IdTipe = idTipe;
        }
    }
}