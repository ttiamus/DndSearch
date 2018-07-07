using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DndSearch.EntityFramework.Base
{
    public class EntityBase
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Timestamp]
        public byte[] TimeStamp { get; set; }

        [Column(TypeName = "datetime2(0)")]
        public DateTime Created { get; set; }

        [Column(TypeName = "datetime2(0)")]
        public DateTime Updated { get; set; }
    }
}
