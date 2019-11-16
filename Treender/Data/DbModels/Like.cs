using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Treender.Data.DbModels
{
    public class Like
    {
        [Key]
        public Guid Uid { get; set; }

        public Guid UserId { get; set; }

        [ForeignKey("UserId")]
        public User UserFk { get; set; }

        public Guid TreeId { get; set; }

        [ForeignKey("TreeId")]
        public Tree TreeFk { get; set; }
    }
}
