using System;

namespace WebApplication2CsvExport.Models
{
    public class AuditTrailEntry
    {
        public string Action { get; set; }

        public string ModifiedBy { get; set; }

        public DateTimeOffset Timestamp { get; set; }
    }
}
