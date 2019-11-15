using System.ComponentModel.DataAnnotations;

namespace Treender.Data.DbModels
{
    public class TreeType
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }
    }
}
