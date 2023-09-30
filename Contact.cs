using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace MyCRM
{
    public class Contact
    {
        public int ContactId { get; set; }
        public string? GivenNames { get; set; }
        public string? FamilyName { get; set; }
        public string? Emails { get; set; }
        public string? FullyQualifiedPhoneNumbers { get; set; }
        public string? OtherChannels { get; set; }
        public string? LastConnectionDate { get; set; }
        public string? RecentNotes { get; set; }
    }
}
