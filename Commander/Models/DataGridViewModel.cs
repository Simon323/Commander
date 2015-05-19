using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commander.Models
{
    public class DataGridViewModel
    {
        public string Path { get; set; }
        public string Name { get; set; }
        public string Size { get; set; }
        public string Date { get; set; }
        public bool IsRoot { get; set; }
    }

    public class CopyPath
    {
        public string Source { get; set; }
        public string Destination { get; set; }
        public bool IsOk { get; set; }

        public CopyPath()
        {
            Source = "";
            Destination = "";
            IsOk = false;
        }
    }
}
