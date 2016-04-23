using Data.Business.Contracts;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    [Table("INFOTABLE_V1")]
    public class OptionsDb : IEntity
    {
        public OptionsDb()
        {
        }

        [Column("INFOID"),
            PrimaryKey,
            NotNull]
        public int Id { get; set; }

        [Column("INFONAME"),
            NotNull,
            Unique,
            Collation("NOCASE"),
            Indexed(Name = "IDX_INFOTABLE_INFONAME", Order = 0, Unique = false)]
        public string Name { get; set; }

        [Column("INFOVALUE"), NotNull]
        public string Type { get; set; }
    }
}
