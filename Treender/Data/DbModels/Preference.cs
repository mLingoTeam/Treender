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

        public int TypeFk { get; set; }

        public int SpecieFk { get; set; }

        [ForeignKey("TypeFk")]
        public TreeType TreeType { get; set; }
        
        [ForeignKey("SpecieFk")]
        public TreeSpecie TreeSpecie { get; set; }
    }
}
