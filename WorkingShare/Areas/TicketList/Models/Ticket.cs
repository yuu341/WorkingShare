using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WorkingShare.Areas.TicketList.Models
{
    public class Ticket
    {

        public int Id { get; set; }

        public string State { get; set; }

        public string Summary { get; set; }

        public string Title { get; set; }

        public bool IsSolved { get; set; }

        public DateTime? SolvedDate { get; set; }

        public DateTime CreateDate { get; set; }

        public int CreateUser { get; set; }
    }
}