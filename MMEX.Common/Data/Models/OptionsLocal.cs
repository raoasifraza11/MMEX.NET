using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    [Table("SETTING_V1")]
    public class OptionsLocal
    {
        public OptionsLocal()
        {
        }

        [Column("SETTINGID"),
            PrimaryKey,
            NotNull]
        public int Id { get; set; }

        [Column("SETTINGNAME"),
            NotNull,
            Unique,
            Collation("NOCASE"),
            Indexed(Name = "IDX_INFOTABLE_INFONAME", Order = 0, Unique = false)]
        public string Name { get; set; }

        [Column("SETTINGVALUE")]
        public string Type { get; set; }
    }
}
