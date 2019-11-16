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

        public int Specie { get; set; }

        public int Type { get; set; }

        [ForeignKey("Specie")]
        public TreeSpecie SpecieFk { get; set; }

        [ForeignKey("Type")]
        public TreeType TypeFk { get; set; }

        public string Description { get; set; }

        public string Location { get; set; }

        public byte[] Image { get; set; }

    }
}
