using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DPOAssesment.Models
{

    public enum SourceApplication
    {
        OMS,
        DMS,
        WMS
    }
    public enum OrderStatus
    {
        Open,
        Picked,
        Packed,
        Shipped,
        Delivered,
        Cancelled
    }

    public class Comment
    {
        [Key]
        public int CommentId { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Comment can not be empty")]
        [StringLength(200, ErrorMessage = "Comment can not be more than 200 charecters")]
        public string CommntText { get; set; }

        [Required(ErrorMessage = "Source application can not be empty")]
        public SourceApplication SourceApplication { get; set; }

        [Required(ErrorMessage = "Order status can not be empty")]
        public OrderStatus OrderStatus { get; set; }

        [Required(ErrorMessage = "UserName can not be empty")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Order id can not be empty")]
        public int OrderId { get; set; }
        public DateTime CreatedAt { get; } = DateTime.Now;

        public virtual Order Order { get; set; }
    }
}