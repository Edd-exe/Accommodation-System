
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Collections;
namespace yurtprojesi.Model
{
    class Security
    {

        /*
        //Data Member
        //Default Private
        int ManagerID;
        string ManagerFirstName;
        string ManagerLastName;
        string ManagerEmail;
        string ManagerPassword;
        //manager type??

        //properties
        public int ManagerID1 { get => ManagerID; set => ManagerID = value; }
        public string ManagerFirstName1 { get => ManagerFirstName; set => ManagerFirstName = value; }
        public string ManagerLastName1 { get => ManagerLastName; set => ManagerLastName = value; }
        public string ManagerEmail1 { get => ManagerEmail; set => ManagerEmail = value; }
        public string ManagerPassword1 { get => ManagerPassword; set => ManagerPassword = value; }
        */

        public bool LoginS(string email, string password, int selecteddL)
        {
            string query = string.Format("SELECT * FROM ManagersInfo WHERE ManagerEmail='{0}' AND ManagerPassword='{1}' AND Type='{2}'", email, password, selecteddL);
            
           
            var dt = DataAccess.ExecuteQuery(query);
            if (dt.Rows.Count > 0)
            {
               
                        return true;
            }
                    
            else
            {
                return false;
            }
        }

        public DataTable GetAllSecurity()
        {
            string query = string.Format("SELECT ID,  ManagerFirstName, ManagerLastName, ManagerEmail, ManagerPassword from ManagersInfo  where Type=1");
            return DataAccess.ExecuteQuery(query);
        } 
      /*  public DataTable GetAllSecurity(string name = null)
        {
            string query = string.Format("SELECT ID,ManagerFirstName, ManagerLastName, ManagerEmail ,ManagerPassword from ManagersInfo where Type=1");
            return DataAccess.ExecuteQuery(query);
        }
    */
        public int AddSecurity(string fname, string lname, string email, string password, int type)
        {
            string query = string.Format("INSERT INTO ManagersInfo(ManagerFirstName,ManagerLastName,ManagerEmail,ManagerPassword,Type) " + "VALUES('{0}', '{1}', '{2}','{3}','{4}')", fname, lname, email, password,type);
          
            return DataAccess.ExecuteNonQuery(query);


        }
        public int UpdateSecurity(string fname, string lname, string email, string password,string id)
        {
            string query = string.Format("UPDATE ManagersInfo SET ManagerFirstName = '{0}'," + "ManagerLastName ='{1}'," + "ManagerEmail ='{2}'," + "ManagerPassword ='{3}'" + "WHERE ID = {4} ", fname, lname, email,password,id);
            return DataAccess.ExecuteNonQuery(query);


        }
        //denemek çin
        public bool IsNumeric(string value)
        {
            return value.All(char.IsNumber);
        }

        public int DeleteSecurity(string id)
        {
            int ide = Convert.ToInt32(id);
            string query =string.Format( "DELETE FROM ManagersInfo WHERE ID={0}" , ide);
            return DataAccess.ExecuteNonQuery(query);
        }

    }
}

