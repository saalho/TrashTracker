using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace TrashTracker.Models
{
    public class Trash
    {
        [PrimaryKey]
        public string Id { get; set; }
        public float Weight { get; set; }
        public string Type { get; set; }
        public DateTime DateTime { get; set; }

    }
}
