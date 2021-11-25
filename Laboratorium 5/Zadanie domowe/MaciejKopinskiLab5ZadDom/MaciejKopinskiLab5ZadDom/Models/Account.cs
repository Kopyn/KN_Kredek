using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MaciejKopinskiLab5ZadDom.Models
{
    public class Account
    {
        /// <summary>
        ///id property
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// login property
        /// </summary>
        [Required]
        [MaxLength(20)]
        public string Login { get; set; }

        /// <summary>
        /// password property
        /// </summary>
        [Required]
        [MaxLength(20)]
        [Display(Name = "Hasło")]
        public string Password { get; set; }

        /// <summary>
        /// email property
        /// </summary>
        [Required]
        [MaxLength(40)]
        public string Email { get; set; }

        /// <summary>
        /// first name property
        /// </summary>
        [Required]
        [MaxLength(30)]
        [Display(Name = "Imię")]
        public string FirstName { get; set; }

        /// <summary>
        /// last name property
        /// </summary>
        [Required]
        [MaxLength(30)]
        [Display(Name = "Nazwisko")]
        public string LastName { get; set; }

        /// <summary>
        /// collection of account's baskets
        /// </summary>
        public ICollection<Basket> Baskets { get; set; }
    }
}
