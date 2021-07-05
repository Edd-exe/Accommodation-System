using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace yurtprojesi.Model
{
  public  class DataAccess
    {
        private static string dbPath = @"data source=C:\database\proje.db";



        //SELECT
        public  static DataTable ExecuteQuery(string query) 
        {
            SQLiteConnection con = new SQLiteConnection(dbPath);
            con.Open();
            SQLiteCommand cmd = new SQLiteCommand(query, con);
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);

            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }
        //INSERT, DELETE , UPDATE
        //int değer döndürür
        public static int ExecuteNonQuery(string query)
        {
            SQLiteConnection con = new SQLiteConnection(dbPath);
            con.Open();
            SQLiteCommand cmd = new SQLiteCommand(query, con);
            cmd.CommandText = query;
            cmd.CommandType = CommandType.Text;
            return cmd.ExecuteNonQuery();
            
        }
    }
}
