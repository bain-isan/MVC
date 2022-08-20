using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BusDetails.Models
{
    public class Repository
    {
        public List<BusInfo> GetAllBusInfo()
        {
            return new BusManagementDBContext().BusInfoes.ToList();
        }

        public void InsertData(BusInfo bd)
        {
            if(bd != null)
            {
                var context = new BusManagementDBContext();
                
                //Stored Procedure
                context.spInsertBusInfo(bd.BoardingPoint, bd.TravelDate, bd.Amount, bd.Rating);
            }
        }
    }
}