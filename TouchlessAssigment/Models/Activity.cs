using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TouchlessAssigment.Models
{
    public class Activity
    {
        public int Id { get; set; }
        public Type Type { get; set; }
        public string AgentMacId { get; set; }
        public Viechle Viechle { get; set; }

    }
    public enum Type
    {
        In,
        Out
    }
}