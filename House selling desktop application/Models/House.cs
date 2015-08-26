using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace House_selling_desktop_application.Models
{
    public class House
    {
        public House()
        {
            Id = Guid.NewGuid();
        }
        public Guid Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }

        //used to hold the state the house is in
        public string Status { get; set; }
        //to hold when the building was finished
        public DateTime BuildingEndDate { get; set; }

    }
}
