using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Application_RSV.Models
{
    public class Reservation
    {
        [Key]
        public int idReservtion { get; set; }
        public DateTime dateTime { get; set; }
        public bool accepter { get; set; }
        [ForeignKey("idType,idstudent")]
        public int IdType { get; set; }
        public string idstudent { get; set; }
        public Student Student { get; set; }
        public typeR typeR { get; set; }
    }
}
