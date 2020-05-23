using System;
using System.Collections.Generic;
using System.Text;

namespace _DB.Model.CONFIGURATION
{
    public class Configuration : BaseEntity
    {
        public TimeSpan Start_Reserving_Time { get; set; }
        public TimeSpan End_Reserving_Time { get; set; }
    }
}
