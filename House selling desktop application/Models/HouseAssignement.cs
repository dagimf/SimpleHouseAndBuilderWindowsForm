using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace House_selling_desktop_application.Models
{
    public class HouseAssignement
    {
        public HouseAssignement()
        {
            WorkerIds = new List<Guid>();
        }
        public Guid HouseIdGuid { get; set; }
        public List<Guid> WorkerIds { get; set; }
    }
}
