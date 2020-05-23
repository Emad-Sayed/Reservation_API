using System;
using System.Collections.Generic;
using System.Text;

namespace _DB.Model.CONFIGURATION
{
    public class Configuration : BaseEntity
    {
        public TimeSpan START_RESERVING_TIME { get; set; }
        public TimeSpan END_RESERVING_TIME { get; set; }
    }
}
