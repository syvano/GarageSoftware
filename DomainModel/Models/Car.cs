using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel.Models
{
    public class Car
    {
        public int Id { get; set; }
        public string Registration { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int Front_Brake_Remaining { get; set; }
        public int Rear_Brake_Remaining { get; set; }
        public int Anti_Freeze_Strength { get; set; }
        public int Odometer { get; set; }

    }

}
