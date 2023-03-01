using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave01.DAL
{
    internal class BilModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Maerke { get; set; }
        public string Model { get; set; }
        public int Vaegt { get; set; }

        public BilModel(int Id, string Maerke, string Model, int Vaegt)
        {
            this.Id = Id;
            this.Vaegt = Vaegt;
            this.Model = Model;
            this.Maerke = Maerke;
        }

        public BilModel() { }

        public override string ToString()
        {
            return Model + " " + Maerke + " " + Vaegt;
        }
    }
}
