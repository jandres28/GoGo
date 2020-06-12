﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoGo_Server
{
    public class AppDb: IDisposable
    {
        public MySqlConnection Connection { get; set; }
        public AppDb(string connectionString) {
            Connection = new MySqlConnection(connectionString);
        }
        public void Dispose() => Connection.Dispose();
    }
}
