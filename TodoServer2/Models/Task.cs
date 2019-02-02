using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TodoServer2.Models
{
    public class Task
    {
        public int Id { get; set; }
        public string OwnerId { get; set; }
        public string Title { get; set; }
        public string Desc { get; set; }
        public Boolean Marked_as_done { get; set; } = false;
        public DateTime Created_at { get; set; } = DateTime.Now;
    }
}