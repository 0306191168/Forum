using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Forum.Models
{
    public class BinhLuan
    {
        public int Ma { get; set; }

        public String NoiDung { get; set; }

        public DateTime NgayTao { get; set; }

        public DateTime NgayXoa { get; set; }
    }
}
