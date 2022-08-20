using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BusDetailsDisplay.Models
{
    public class Repository
    {
        public List<BusInfo> GetAllBuses()
        {
            return new BusManagementDBContext().BusInfoes.ToList();
        }
    }
}