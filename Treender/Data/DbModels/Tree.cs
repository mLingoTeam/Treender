using System;

namespace Treender.Data.DbModels
{
    public class Tree
    {
        public string Name { get; set; }

        public Guid Uid { get; set; }

        public int Height { get; set; }

        public int Specie { get; set; }

        public int TreeType { get; set; }

        public string Description { get; set; }

        public string Location { get; set; }

        public byte[] Image { get; set; }

    }
}
