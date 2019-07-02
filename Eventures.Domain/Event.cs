using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Eventures.Domain
{
    public class Event
    {
        //•	Id – a GUID.
        //•	Name – a string.
        //•	Place – a string.
        //•	Start – a DateTime object.
        //•	End – a DateTime object.
        //•	Total Tickets – an integer.
        //•	Price Per Ticket – a decimal value.

        public string Id { get; set; }

        public string Name { get; set; }

        public string Place { get; set; }

        public DateTime Start { get; set; }

        public DateTime? End { get; set; }


        public int TotalTickets { get; set; }

        [Column(TypeName = "decimal(16,2)")]
        public decimal PricePerTicket { get; set; }

    }
}
