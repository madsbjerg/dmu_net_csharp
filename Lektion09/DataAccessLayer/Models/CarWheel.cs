using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Models
{
    public class CarWheel
    {
        [Key]
        public int Id { get; set; }
        public int CarId { get; set; }
        public int WheelId { get; set; }

        public CarWheel() { }
        public CarWheel(int id, int carId, int wheelId) 
        {
            Id = id;
            CarId = carId;
            WheelId = wheelId;
        }
    }
}
