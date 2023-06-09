﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook.Data.Entities
{
    public class Comment
    {
        [Key]
        public int Id { get; set; }
        public string Body { get; set; }

        public int PostId { get; set; }
        public Post Post { get; set; }
    }
}
