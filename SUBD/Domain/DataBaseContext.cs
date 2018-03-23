﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Domain
{
    public class DataBaseContext : DbContext
    {
        // в base строка подключения к бд. Оно так работает, я не знаю как красиво сделать. 
        // Data Source=DESKTOP-JIUUOJ8\SQLEXPRESS; -- это сервер
        // Initial Catalog=MetaBase; -- это название базы данных )

        // "Persist Security Info=False;User ID=sa;Password=Erestor412;Initial Catalog=MetaBase;Server=localhost,1433"

        // (@"Data Source=DESKTOP-JIUUOJ8\SQLEXPRESS;Initial Catalog=MetaBase;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False")
        public DataBaseContext() : 
            base(@"Data Source=DESKTOP-JIUUOJ8;Initial Catalog=MetaBase;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False")
        {

        }

        public DbSet<Column> Columns { get; set; }
        public DbSet<Database> Databases { get; set; }
        public DbSet<Mask> Masks { get; set; }
        public DbSet<Relation> Relations { get; set; }
        public DbSet<Server> Servers { get; set; }
        public DbSet<Table> Tables { get; set; }
        public DbSet<Type> Types { get; set; }
    }
}
