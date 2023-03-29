using System.Collections.Generic;

namespace WpfApp3.Models
{
    internal class CountryInfo : PlaseInfo
    {
        public IEnumerable<PlaseInfo> ProvinceCounts { get; set; }
    }

}
