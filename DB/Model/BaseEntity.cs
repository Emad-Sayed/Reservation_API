using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace _DB.Model
{
    public class BaseEntity
    {
        public BaseEntity()
        {
            CREATED_DATE = DateTime.Now;
        }
        public int Id { get; set; }
        public DateTime CREATED_DATE { get; set; }
        public DateTime? LAST_UPDATE { get; set; }
        [DefaultValue(false)]
        public bool IS_DELETED { get; set; }
    }
}
