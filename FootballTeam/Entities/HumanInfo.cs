using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballTeam.Entities
{
    public class HumanInfo
    {
        [Key, ForeignKey("Human")]
        public int HumanId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public int Age { get; set; }
        public string Position { get; set; }
        [Required]
        public int Efficiency { get; set; }

        public virtual Human Human { get; set; }
    }
}
