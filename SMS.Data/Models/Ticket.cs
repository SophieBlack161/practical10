using System;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace SMS.Data.Models
{
    // used in ticket search feature
    public enum TicketRange { OPEN, CLOSED, ALL }

    public class Ticket
    {
        public int Id { get; set; }
        
        [Required]
        [StringLength(500, MinimumLength = 5)]
        public string Issue { get; set; }

        // TBC - add Resolution string attribute and ResolvedOn DateTime (initialise with DateTime.Min)
        //resolution not required

        [StringLength(500)]
        public string Resolution {get;set;}
        
        public DateTime CreatedOn { get; set; } = DateTime.Now;
        public DateTime ResolvedOn {get; set;} = DateTime.MinValue;
       
        public bool Active { get; set; } = true;
        //public bool Active => ResolvedOn == DateTime.MinValue;


        // ticket owned by a student
        public int StudentId { get; set; }      // foreign key
        public Student Student { get; set; }    // navigation property
    } 
}
