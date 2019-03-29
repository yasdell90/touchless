using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TouchlessAssigment.Models;

namespace TouchlessAssigment.Controllers
{
    public class TrafficController : ApiController
    {
        Viechle v = new Viechle
        {
            PlateNumber = "abcd1234",
            TimeStamp = (Int32)(DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1))).TotalSeconds
        };
        string InAgentMacId = "00 - 14 - 22 - 01 - 23 - 45";
        string OutAgentMacId = "00 - 14 - 22 - 01 - 23 - 46";
       
        public string Get()
        {
            return NewActivity(v, InAgentMacId, OutAgentMacId).ToString();
        }

        public Activity NewActivity (Viechle viecle ,string inMacID, string outMacId)
        {
            var activity = new Activity {
                Type = GetActivityType(inMacID, outMacId),
                AgentMacId = string.IsNullOrEmpty(inMacID)?outMacId :inMacID
                
            };
            activity.Viechle.PlateNumber = viecle.PlateNumber;
            activity.Viechle.TimeStamp = viecle.TimeStamp;
            return activity;
        }
        private Models.Type GetActivityType(string inMacID, string outMacId)
        {
            if ((string.IsNullOrEmpty(inMacID) && (string.IsNullOrEmpty(outMacId)) )||(!string.IsNullOrEmpty(inMacID) && (!string.IsNullOrEmpty(outMacId))))
            {
                throw new EntryPointNotFoundException();
            }
            else
            {
                if(string.IsNullOrEmpty(inMacID))
                return Models.Type.Out;
                return Models.Type.In;
            }
        }
    }
}
