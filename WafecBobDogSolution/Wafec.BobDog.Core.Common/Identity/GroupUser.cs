using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Wafec.BobDog.Core.Common.Identity
{
    [Table("GROUP_USER")]
    public class GroupUser
    {
        [Key]
        [Column("ID")]
        public long ID { get; set; }
        [Column("GROUP_ID")]
        [ForeignKey("Group")]
        public long GroupID { get; set; }
        [Column("USER_ID")]
        [ForeignKey("User")]
        public long UserID { get; set; }
        public virtual Group Group { get; set; }
        public virtual User User { get; set; }
    }
}
