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
            Created_Date = DateTime.Now;
        }
        public int Id { get; set; }
        public DateTime Created_Date { get; set; }
        public DateTime? Last_Update { get; set; }
        [DefaultValue(false)]
        public bool Is_Deleted { get; set; }
    }
}
