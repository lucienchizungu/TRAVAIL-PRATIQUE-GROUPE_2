﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace TP2.Connection
{
    class dbConnection
    {

        public SqlConnection GetSqlConnection()
        {
            return new SqlConnection("Data source=DESKTOP-IALFIS6;Initial catalog=db_person;User=sa;password=luc");
        }

        public MySqlConnection GetMySqlConnection()
        {
            return new MySqlConnection("Datasource=localhost;port=3306;Initial catalog=db_person;username=root;password=");
        }
    }
}
