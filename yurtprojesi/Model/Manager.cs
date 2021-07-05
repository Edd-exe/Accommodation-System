using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Collections;

namespace yurtprojesi.Model
{
    class Manager
    {
        //int ManagerID;
        //string Password;






        public bool Login(string email, string password,int selecteddL)
        {
            string query = string.Format("SELECT * FROM ManagersInfo WHERE ManagerEmail='{0}' AND ManagerPassword='{1}' AND Type='{2}'", email, password, selecteddL);

            var dt = DataAccess.ExecuteQuery(query);
            if(dt.Rows.Count>0)
            {
                return true;
               
                  
            }
            else
            {
                return false;
            }
        }
        public DataTable GetAllManager()
        {
            string query = string.Format("SELECT ID,  ManagerFirstName, ManagerLastName, ManagerEmail, ManagerPassword from ManagersInfo  where Type=0");
            return DataAccess.ExecuteQuery(query);
        }
        /*  public DataTable GetAllSecurity(string name = null)
          {
              string query = string.Format("SELECT ID,ManagerFirstName, ManagerLastName, ManagerEmail ,ManagerPassword from ManagersInfo where Type=1");
              return DataAccess.ExecuteQuery(query);
          }
      */
        public int UpdateManager(string newpassword, string tboldpassword)
        {
            string query = string.Format("UPDATE ManagersInfo SET ManagerPassword = '{0}'" + "WHERE ManagerPassword = '{1}' ", newpassword, tboldpassword);
            return DataAccess.ExecuteNonQuery(query);


        }
    }
}
