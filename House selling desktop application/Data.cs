using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using House_selling_desktop_application.Models;

namespace House_selling_desktop_application
{
    public static class Data
    {
        public static List<House> Houses = new List<House>();
        public static List<HouseAssignement> Assignements = new List<HouseAssignement>();
        public static List<Worker> Workers = new List<Worker>
        {
            new Worker{Name = "Kevin Henery", Type = WorkerTypes.Builder},
            new Worker{Name = "Raphael Milian", Type = WorkerTypes.Builder},
            new Worker{Name = "Will Smith", Type = WorkerTypes.Manager}

        };
    }
}
