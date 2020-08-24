using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Wafec.BobDog.Core.Common.Identity
{
    [Table("USER_TOKEN")]
    public class UserToken
    {
        [Key]
        [Column("ID")]
        public long ID { get; set; }
        [Column("USER_ID")]
        [ForeignKey("User")]
        public long UserID { get; set; }
        [Column("TOKEN")]
        public string Token { get; set; }
        [Column("EXPIRES_IN")]
        public DateTime ExpiresIn { get; set; }
        [Column("CREATED_AT")]
        public DateTime CreatedAt { get; set; }
        public virtual User User { get; set; }
    }
}
