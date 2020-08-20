using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Wafec.BobDog.Core.Common.Identity
{
    [Table("GROUP_ROLE")]
    public class GroupRole
    {
        [Key]
        [Column("ID")]
        public long ID { get; set; }
        [Column("GROUP_ID")]
        [ForeignKey("Group")]
        public long GroupID { get; set; }
        [Column("ROLE_ID")]
        [ForeignKey("Role")]
        public long RoleID { get; set; }
        public virtual Group Group { get; set; }
        public virtual Role Role { get; set; }
    }
}
