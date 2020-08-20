using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Wafec.BobDog.Core.Common.Identity
{
    [Table("USER_ROLE")]
    public class UserRole
    {
        [Key]
        [Column("ID")]
        public long ID { get; set; }
        [Column("USER_ID")]
        [ForeignKey("User")]
        public long UserID { get; set; }
        [Column("ROLE_ID")]
        [ForeignKey("Role")]
        public long RoleID { get; set; }
        public virtual User User { get; set; }
        public virtual Role Role { get; set; }
    }
}
