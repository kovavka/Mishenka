using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Storage
{
    class TableStorage
    {
        DataBaseContext context = new DataBaseContext();

        public Table Add(Table table)
        {
            return context.Tables.Add(table);
        }

    }
}
