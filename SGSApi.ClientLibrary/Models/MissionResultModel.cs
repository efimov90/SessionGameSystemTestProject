using System;
using System.Collections.Generic;
using System.Text;

namespace SGSApi.ClientLibrary.Models
{
    public class MissionResultModel
    {
        public int Id { get; set; }
        public DateTime MissionStarted { get; set; }
        public DateTime MissionEnded { get; set; }
        public int MissionEndStatus { get; set; }
    }
}
