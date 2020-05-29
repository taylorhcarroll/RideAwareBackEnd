using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RideAwareFS.Models
{
    public class StudentUser
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public int UserId { get; set; }
        public bool PrimaryUser { get; set; }
        public bool Expire { get; set; }
        public DateTime ExpireDate { get; set; }


    }
}
