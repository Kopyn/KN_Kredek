using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MaciejKopinskiLab5ZadDom.Models
{
    public class Guitar
    {
        /// <summary>
        /// id property
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// manufacturer name
        /// </summary>
        [Required]
        [Display(Name = "Producent")]
        public int ManufacturerId { get; set; }

        [ForeignKey("ManufacturerId")]
        public Manufacturer Manufacturer { get; set; }

        /// <summary>
        /// model property
        /// </summary>
        [Required]
        [MaxLength(30)]
        public string Model { get; set; }

        /// <summary>
        /// type property
        /// </summary>
        [Required]
        [MaxLength(30)]
        [Display(Name = "Typ")]
        public string Type { get; set; }

        /// <summary>
        /// basket in which the guitar is
        /// </summary>
        public Basket Basket { get; set; }

    }
}
