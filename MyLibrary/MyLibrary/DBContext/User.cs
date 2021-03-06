﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MyLibrary.DBContext
{
    [MetadataType(typeof(UserMetadata))]
    public partial class User
    {
        public User() { }

        [Key, ForeignKey("BookStatus")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Forename { get; set; }
        public string Surname { get; set; }

        public virtual BookStatus BookStatus { get; set; }
    }
}