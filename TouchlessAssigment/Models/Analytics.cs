using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TouchlessAssigment.Models
{
    public class Analytics
    {
        public DateTime Date { get; set; }
        public int TotalSessions { get; set; }
        public int OnGoingSessions{ get; set; }
        public int FinishedSessions { get
            {
                return TotalSessions - OnGoingSessions;
            }
        }
    }
}