using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballTeam.Entities
{
    public class Human
    {
        [Key]
        public int HumanId { get; set; }

        [Required]
        public int IdOfClub { get; set; }

        [Required]
        public int IdOfRole { get; set; }

        public virtual HumanInfo HumanInfo { get; set; }

        [ForeignKey("IdOfRole")]
        public virtual Role Role { get; set; }
        [ForeignKey("IdOfClub")]
        public virtual Team Team { get; set; }
    }
}
