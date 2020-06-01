using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace DataTableLikeSQL
{
    public class DDL
    {
        public static DataTable CreateTable(string tableName, DataColumn[] columns)
        {
            var table = new DataTable(tableName);
            table.Columns.AddRange(columns);
            return table;
        }

    }
}
