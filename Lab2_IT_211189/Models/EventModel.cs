using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Lab2_IT_211189.Models
{
    public class EventModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [Required]
        [StringLength(99, MinimumLength = 5, ErrorMessage = "Name must be between 5-99 characters long")]
        public string Location { get; set; }
    }
}