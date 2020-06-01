using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace DataTableLikeSQL
{
    public static class Extensions
    {
        public static void AlterTableAddPrimaryKey(this DataTable table, string[] columnName)
        {
            var keys = new List<DataColumn>();
            foreach (DataColumn clm in table.Columns)
            {
                if (columnName.Contains(clm.ColumnName))
                {
                    keys.Add(clm);
                }
            }
            Debug.Assert(keys.Count > 0);
            table.PrimaryKey = keys.ToArray();
        }

    }
}
