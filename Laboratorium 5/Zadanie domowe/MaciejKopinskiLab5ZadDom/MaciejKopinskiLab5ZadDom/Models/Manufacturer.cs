using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MaciejKopinskiLab5ZadDom.Models
{
    public class Manufacturer
    {
        /// <summary>
        /// id property
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// name property
        /// </summary>
        [Required]
        [MaxLength(30)]
        [Display(Name = "Marka")]
        public string Name { get; set; }

    }
}
