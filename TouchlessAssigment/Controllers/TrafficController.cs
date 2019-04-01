using System;
using System.Web.Http;
using TouchlessAssigment.Models;

using Newtonsoft.Json;

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
       [HttpGet]
        public string index()
        {
            var result = JsonConvert.SerializeObject( NewActivity(v, InAgentMacId, OutAgentMacId));
            return result;
        }

        public Activity NewActivity (Viechle viecle ,string inMacID, string outMacId)
        {
            var activity = new Activity {
                Type = GetActivityType(inMacID, outMacId),
                AgentMacId = string.IsNullOrEmpty(inMacID)?outMacId :inMacID
                
            };

            activity.Viechle = new Viechle
            {
                PlateNumber = viecle.PlateNumber,
                TimeStamp = viecle.TimeStamp

            };

           
            return activity;
        }
        private Models.Type GetActivityType(string inMacID, string outMacId)
        {
                if(string.IsNullOrEmpty(outMacId))
                return Models.Type.In;
                return Models.Type.Out;
            
        }
    }
}
