using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SQLite;
using yurtprojesi.Model;
namespace yurtprojesi.Model
{
    class Room
    {
        public int UpdateRoom(string roomno )
        {
            
            string query = string.Format("Insert into StudentsInfo (RoomNo )values( 'A11')", roomno);
            return DataAccess.ExecuteNonQuery(query);
        }
    }
}
