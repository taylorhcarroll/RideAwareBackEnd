using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RideAwareFS.Models
{
    public class User
    {
        public string Id { get; set; }

        public bool Admin { get; set; }

        public string AvatarUrl { get; set; }

        public int LocationId { get; set; }
    }
}
