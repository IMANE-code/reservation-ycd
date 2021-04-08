using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Application_RSV.Models
{
    public class typeR
    {
        [Key]
        public int idType { get; set; }
        public string name { get; set; }
        public int nomber_apprenant { get; set; }
        public List<Reservation> reservations { get; set; }
    }
}
