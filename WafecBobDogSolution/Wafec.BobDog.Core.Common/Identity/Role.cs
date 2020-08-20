using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Wafec.BobDog.Core.Common.Identity
{
    [Table("ROLE")]
    public class Role
    {
        [Key]
        [Column("ID")]
        public long ID { get; set; }
        [Column("NAME")]
        public string Name { get; set; }
    }
}
