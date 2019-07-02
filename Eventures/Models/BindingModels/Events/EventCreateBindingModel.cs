using Eventures.Attributes;
using System;
using System.ComponentModel.DataAnnotations;

namespace Eventures.Models.BindingModels.Events
{
    public class EventCreateBindingModel
    {
        [Required]
        [StringLength(255, MinimumLength = 10, ErrorMessage = "Event name must be at least 10 symbols.")]
        public string Name { get; set; }

        [Required(AllowEmptyStrings = false)]
        public string Place { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [DateBefore(nameof(End), ErrorMessage = "Start date cannot be after end date.")]
        public DateTime Start { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime End { get; set; }

        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "Tickets count can not be less then 1.")]
        [Display(Name = "Total Tickets")]
        public int TotalTickets { get; set; }

        [Required]
        [Range(typeof(decimal), "0.01", "79228162514264337593543950335", ParseLimitsInInvariantCulture = true)]
        [Display(Name = "Price per Ticket")]
        public decimal PricePerTicket { get; set; }
    }
}
