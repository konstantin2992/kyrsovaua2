using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using static System.Reflection.Metadata.BlobBuilder;

namespace HumanResuorces.Models
{
    internal class TerminationReason
    {
        public string Reason { get; set; }

        public TerminationReason(string reason)
        {
            Reason = reason;
        }

        public override string ToString()
        {
            return Reason;
        }
    }
}
