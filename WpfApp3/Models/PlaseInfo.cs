using System.Collections.Generic;
using System.Windows;

namespace WpfApp3.Models
{
    internal class PlaseInfo    
    {
        public string Name { get; set; }
        public Point Location { get; set; }
        public IEnumerable<ConfirmedCount> Counts { get; set; }
    }

}
