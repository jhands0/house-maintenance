using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace backend.Models
{
    public class TaskEntry
    {
        [Key]
        public long Id { get; set; }
        
        public int RoomNo { get; set; }
        
        [Column(TypeName = "nvarchar(100)")]
        public string Task { get; set; }
        
        public int Code { get; set; }
        
        [Column(TypeName = "tinytext")]
        public string Comments { get; set; }

        [Column(TypeName = "bool")]
        public bool Completed { get; set; }

        [Column(TypeName = "date")]
        public DateTime Date { get; set; }

        public int Priority { get; set; }

        # TODO: Change RoomNo, Code and Priority records to their own Enums
    }
}