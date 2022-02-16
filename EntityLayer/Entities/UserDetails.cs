﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Entities
{
    public class UserDetails
    {
        public int DetailsId { get; set; }
        public int UserId { get; set; }
        public string Email { get; set; }
        public int? Age { get; set; }
        public string Gender { get; set; }
        public string FullName { get; set; }

    }
}
