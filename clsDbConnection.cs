using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Enrollment_Management_System
{
    internal class clsDbConnection
    {
        public static string _connection = "server=localhost; user id=root;password=;database=enrollmentsystemdb";
        public static string _title = "Enrollment Management System";
        public static string _aycode = "";
    }
}   