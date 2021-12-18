using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    class File
    {
        public int SizeBytes { get; set; }
        public int CalculateSizeKilobytes()
        {
            return SizeBytes / 1024;
        }
    }
}
