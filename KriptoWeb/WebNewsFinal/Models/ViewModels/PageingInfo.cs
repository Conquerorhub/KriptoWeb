using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebNewsFinal.Models.ViewModels
{
    public class PageingInfo
    {
        public int totalParticipant { get; set; }
        public int participantperPage { get; set; }
        public int CurrentPage { get; set; }
        public int totalPages => (int)Math.Ceiling((decimal)totalParticipant / participantperPage);
    }
}
