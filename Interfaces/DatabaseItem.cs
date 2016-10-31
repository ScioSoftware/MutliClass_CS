using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace MultiClass_CS.Interfaces
{
    interface DatabaseItem
    {
        String tableName { get; }
        int? ID { get; set; }
        DatabaseItem convertFromRow(DataRow row);
        DataRow convertToRow(DatabaseItem item);
    }
}
