using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Treender.Data.DbModels
{
    public class Tree
    {
        public string Name { get; set; }

        [Key]
        public Guid Uid { get; set; }

        public int Height { get; set; }

        public int SpecieFk { get; set; }

        public int TypeFk { get; set; }

        [ForeignKey("SpecieFk")]
        public TreeSpecie Specie { get; set; }

        [ForeignKey("TypeFk")]
        public TreeType TreeType { get; set; }

        public string Description { get; set; }

        public string Location { get; set; }

        public byte[] Image { get; set; }

    }
}
