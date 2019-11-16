using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Treender.Data.DbModels
{
    public class Preference
    {
        [Key]
        public Guid Uid { get; set; }

        public int MinHeight { get; set; }

        public int MaxHeight { get; set; }

        public int Type { get; set; }

        public int Specie { get; set; }

        [ForeignKey("Type")]
        public TreeType TypeFk { get; set; }
        
        [ForeignKey("Specie")]
        public TreeSpecie SpecieFk { get; set; }
    }
}
