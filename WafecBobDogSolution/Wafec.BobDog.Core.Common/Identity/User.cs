using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Wafec.BobDog.Core.Common.Identity
{
    [Table("USER")]
    public class User
    {
        [Key]
        [Column("ID")]
        public long ID { get; set; }
        [Column("USERNAME")]
        public string Username { get; set; }
        [Column("PASSWD")]
        public string Password { get; set; }
    }
}
