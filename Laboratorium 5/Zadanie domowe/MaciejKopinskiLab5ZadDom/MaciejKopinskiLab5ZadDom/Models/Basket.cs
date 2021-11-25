using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MaciejKopinskiLab5ZadDom.Models
{
    public class Basket
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
        [Display(Name = "Identyfikator konta")]
        public int AccountId { get; set; }

        /// <summary>
        /// relation
        /// </summary>
        [ForeignKey("AccountId")]
        public Account Account { get; set; }

        /// <summary>
        /// collection of guitars
        /// </summary>
        public ICollection<Guitar> Guitars { get; set; }

    }
}
