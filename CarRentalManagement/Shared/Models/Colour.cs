using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalManagement.Shared.Models
{
    public class Colour : BaseModel
    {
        public string Name { get; set; }

       public virtual List<Vehicle>? Vehicle { get; set; }
    }
}
