using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MaciejKopinskiLab6ZadDom.Models
{
    public class Guitar
    {
        //guiter id
        public int Id { get; set; }

        //guitar's manufacturer id
        public int ManufacturerId { get; set; }

        //guitar model
        public string Model { get; set; }

        //guitar type
        public string Type { get; set; }

        //id of basket in which the guitar is
        public int BasketId { get; set; }
    }
}
