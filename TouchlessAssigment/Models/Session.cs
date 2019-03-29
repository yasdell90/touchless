using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TouchlessAssigment.Models
{
    public class Session
    {
        public int SessionID { get; set; }
        public string PlateNumber { get; set; }
        public int InTime { get {
                return (Int32)(DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1))).TotalSeconds;
            } }
        public int? OutTime
        {
            get
            {
                return (Int32)(DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1))).TotalSeconds;
            }
        }
        public string InAgentMACID { get; set; }
        public string OutAgentMACID { get; set; }

    }
    
}