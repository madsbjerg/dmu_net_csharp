using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Models
{
    internal class Wheel
    {
        [Key]
        public int Id { get; set; }
        public string Brand { get; set; }
        public List<int> carWheelIds { get; set; }
    }
}
