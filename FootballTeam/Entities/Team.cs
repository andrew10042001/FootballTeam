using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballTeam.Entities
{
    public class Team
    {
        [Key]
        public int IdOfClub { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string City { get; set; }
        [Required]
        public string Country { get; set; }

        public virtual ICollection<Human> Humans { get; set; }

    }
}
