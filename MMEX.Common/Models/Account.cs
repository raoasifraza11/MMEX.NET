using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    [Table("ACCOUNTLIST_V1")]
    public class Account
    {
        public Account()
        {
        }

        [Column("ACCOUNTID"),
            PrimaryKey,
            NotNull]
        public int Id { get; set; }

        [Column("ACCOUNTNAME"),
            NotNull,
            Unique,
            Collation("NOCASE"),
            Indexed(Name = "IDX_ACCOUNTLIST_ACCOUNTTYPE", Order = 0, Unique = false)]
        public string Name { get; set; }

        [Column("ACCOUNTTYPE"),
            NotNull]
        public string Type { get; set; }

        [Column("ACCOUNTNUM")]
        public string Number { get; set; }

        [Column("STATUS"),
            NotNull]
        public string Status { get; set; }

        [Column("NOTES")]
        public string Notes { get; set; }

        [Column("HELDAT")]
        public string HeldAt { get; set; }

        [Column("WEBSITE")]
        public string Website { get; set; }

        [Column("CONTACTINFO")]
        public string ContactInfo { get; set; }

        [Column("ACCESSINFO")]
        public string AccessInfo { get; set; }

        [Column("INITIALBAL")]
        public string InitialBalance { get; set; }

        [Column("FAVORITEACCT"),
            NotNull]
        public string Favorite { get; set; }

        [Column("CURRENCYID"),
            NotNull]
        public string Currency { get; set; }
    }
}
