using System;

namespace Treender.Data.DbModels
{
    public class User
    {
        public string Username { get; set; }

        public Guid Uid { get; set; }

        public int Preferences { get; set; }
    }
}
