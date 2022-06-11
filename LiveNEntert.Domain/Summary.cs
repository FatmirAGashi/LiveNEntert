using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiveNEntert.Domain
{
    public class Summary : ModelBase
    {
        public string Result { get; set; }
        public int Live { get; set; }
        public int Nation { get; set; }
        public int LiveNation { get; set; }
        public int Integer { get; set; }
    }
}
