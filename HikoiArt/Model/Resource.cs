using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace HikoiArt.Model
{
    class Resource
    {
        [PrimaryKey]
        public int Id { get; set; }
        public string ItemName { get; set; }
        public string Inventory { get; set; }

        public override string ToString()
        {
            return this.ItemName + " " + this.Inventory;
        }
    }
}
