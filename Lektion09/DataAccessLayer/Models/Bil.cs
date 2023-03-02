using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Models
{
    public class Bil
    {
        [Key]
        public int Id { get; set; }
        public string Model { get; set; }
        public string Type { get; set; }
        public string Weight { get; set; }
        public string Description { get; set; }

        public Bil(int id, string model, string type, string weight, string description)
        {
            Id = id;
            Model = model;
            Type = type;
            Weight = weight;
            Description = description;
        }
        public Bil() { }
    }
}
