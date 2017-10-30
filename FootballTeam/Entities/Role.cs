using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballTeam.Entities
{
    public class Role
    {
        [Key]
        public int IdOfRole { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        public virtual ICollection<Human> Humans { get; set; }
    }
}
