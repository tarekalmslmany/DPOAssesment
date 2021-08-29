using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DPOAssesment.Models
{
    public enum Status
    {
        Open,
        picked,
        packed,
        shipped,
        delivered,
        cancelled
    }
    public class Order
    {
        [Key]
        public int OrderId { get; set; }

        //this reqierd to know this order sub of which user
        //[Required(ErrorMessage ="SubOf Can not be empty"]
        //public User SubOf { get; set; }

        //this reqierd to know wiche address id that user had used
        //[Required(ErrorMessage ="AddressId Can not be empty"]
        //public User AddressId { get; set; }

        [Required(ErrorMessage = "Price can not be empty")]
        public float Price { get; set; }

        [Required(ErrorMessage = "SubTotal can not be empty")]
        public float SubTotal { get; set; }

        public DateTime CreatedAt { get; } = DateTime.Now;


        [Required(ErrorMessage = "Status can not be empty")]
        public Status Status { get; set; }

        public virtual ICollection<Comment> Comments { get; set; }
    }
}