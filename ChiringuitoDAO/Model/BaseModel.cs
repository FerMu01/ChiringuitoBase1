using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChiringuitoDAO.Model
{
    public class BaseModel
    {
        public byte Status { get; set; }
        public DateTime RegisterDate { get; set; }
        public DateTime LastUpdate { get; set; }
        public short UserID { get; set; }

        public BaseModel() 
        {
            
        }
        public BaseModel(byte status, DateTime registerDate, DateTime lastUpdate, short userID)
        {
            Status = status;
            RegisterDate = registerDate;
            LastUpdate = lastUpdate;
            UserID = userID;
        }

     
    }
}
