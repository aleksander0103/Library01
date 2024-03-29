﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace UserManager.Entities
{
    [Table("Phones")]
    public class Phone
    { public int Id { get; set; }
        public int ContactId { get; set; }
        public string Number { get; set; }
        [ForeignKey("ContactId")]
        public Contact Contact { get; set; }
    }
}