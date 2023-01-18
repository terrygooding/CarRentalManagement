using CarRentalManagement.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalManagement.Shared.Models
{
    public class Manufacturer : BaseModel
    {
        public string Name { get; set; }

        public virtual List<Vehicle>? Vehicle { get; set; }
    }
}
