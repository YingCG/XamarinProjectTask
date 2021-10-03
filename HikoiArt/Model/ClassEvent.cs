using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace HikoiArt.Model
{
    public class ClassEvent
    {

        [PrimaryKey]
        public int Id { get; set; }

        public string Title { get; set; }
        public string Purpose { get; set; }
        public string Theme { get; set; }
        public string MaterialList { get; set; }
        public string References { get; set; }
        public string Promotion { get; set; }

        public override string ToString()
        {
            const string newLine = "\n";
            return string.Concat(Id, newLine,
                Title, newLine,
                Purpose, newLine,
                Theme, newLine,
                MaterialList, newLine,
                References, newLine,
                Promotion, newLine
                );
        }
    }
}
