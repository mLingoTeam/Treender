using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Treender.Data.DbModels
{
    public class User
    {
        public string Username { get; set; }

        [Key]
        public Guid Uid { get; set; }

        public Guid PreferencesFk { get; set; }

        [ForeignKey("PreferencesFk")]
        public Preference Preferences { get; set; }
    }
}
