using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yurtprojesi.Model
{
    class Student
    {
        //Data Member
        //Default Private
        int StudentID;
        string FirstName;
        string LastName;
        string Email;
        string Telephone;
        string Gender;
        int Department;
        string ParentName;
        string ParentTelephone;
        int RoomNo;
        int Debt;
        //int Payment;

        //properties
        public int StudentID1 { get => StudentID; set => StudentID = value; }
        public string FirstName1 { get => FirstName; set => FirstName = value; }
        public string LastName1 { get => LastName; set => LastName = value; }
        public string Email1 { get => Email; set => Email = value; }
        public string Telephone1 { get => Telephone; set => Telephone = value; }
        public string Gender1 { get => Gender; set => Gender = value; }
        public int Department1 { get => Department; set => Department = value; }
        public string ParentName1 { get => ParentName; set => ParentName = value; }
        public string ParentTelephone1 { get => ParentTelephone; set => ParentTelephone = value; }
        public int RoomNo1 { get => RoomNo; set => RoomNo = value; }
        public int Debt1 { get => Debt; set => Debt = value; }
       // public int Payment1 { get => Payment; set => Payment = value; }

        public DataTable GetAllStudents()
        {
            string query = string.Format("SELECT StudentID, FirstName, LastName, Email, Telephone, Gender, ParentName, ParentTelephone, RoomNo, DepartmentsInfo.DepartmentName from StudentsInfo inner join DepartmentsInfo on StudentsInfo.DepartmentID = DepartmentsInfo.DepartmentID");
            return DataAccess.ExecuteQuery(query);
        }
        public DataTable GetAllStudents(string name = null)
        {
            string query = string.Format("SELECT StudentID, FirstName, LastName, Email, Telephone, Gender, ParentName,ParentLastName, ParentTelephone, RoomNo,Address ,DepartmentsInfo.DepartmentName from StudentsInfo inner join DepartmentsInfo on StudentsInfo.DepartmentID = DepartmentsInfo.DepartmentID");
            return DataAccess.ExecuteQuery(query);
        }
        public DataTable GetStudentByID(int id)
        {
            string query = string.Format("SELECT StudentID, FirstName, LastName, Email, Telephone, Gender, ParentName, ParentTelephone, RoomNo, DepartmentsInfo.DepartmentName from StudentsInfo inner join DepartmentsInfo on StudentsInfo.DepartmentID = DepartmentsInfo.DepartmentID where StudentID = " + id);
            return DataAccess.ExecuteQuery(query);
        }

        public DataTable GetStudentByName(string name)
        {
            string query = string.Format("SELECT StudentID, FirstName, LastName, Email, Telephone, Gender, ParentName, ParentTelephone, RoomNo, DepartmentsInfo.DepartmentName from StudentsInfo inner join DepartmentsInfo on StudentsInfo.DepartmentID = DepartmentsInfo.DepartmentID where FirstName Like '{0}%'", name);
            return DataAccess.ExecuteQuery(query);
        }
        public DataTable GetStudentByRoomNo(string rno)
        {
           
            string query = string.Format("SELECT StudentID, FirstName, LastName, Email, Telephone, Gender, ParentName, ParentTelephone, RoomNo, DepartmentsInfo.DepartmentName from StudentsInfo inner join DepartmentsInfo on StudentsInfo.DepartmentID = DepartmentsInfo.DepartmentID where RoomNo like '{0}%'", rno);
            return DataAccess.ExecuteQuery(query);
        }
        public DataTable GetStudentByTelephone(string telno)
        {
            string query = string.Format("SELECT StudentID, FirstName, LastName, Email, Telephone, Gender, ParentName, ParentTelephone, RoomNo, DepartmentsInfo.DepartmentName from StudentsInfo inner join DepartmentsInfo on StudentsInfo.DepartmentID = DepartmentsInfo.DepartmentID where Telephone = '{0}'", telno);
            return DataAccess.ExecuteQuery(query);
        }
        public DataTable GetStudentByDepartment(string dep)
        {
            string query = string.Format("SELECT StudentID, FirstName, LastName, Email, Telephone, Gender, ParentName, ParentTelephone, RoomNo, d.DepartmentName from StudentsInfo s inner join DepartmentsInfo d on s.DepartmentID = d.DepartmentID where d.DepartmentName Like '{0}%'", dep);
            return DataAccess.ExecuteQuery(query);
        }

        public DataTable GetStudentByLastName(string lastname)
        {
            string query = string.Format("SELECT StudentID, FirstName, LastName, Email, Telephone, Gender, ParentName, ParentTelephone, RoomNo, DepartmentsInfo.DepartmentName from StudentsInfo inner join DepartmentsInfo on StudentsInfo.DepartmentID = DepartmentsInfo.DepartmentID where LastName Like '{0}%'", lastname);
            return DataAccess.ExecuteQuery(query);
        }
        public int AddStudent(string fname, string lname, string email, string tel, string gender, int departmentid, string pname, string plname, string ptel,string address,int disc,int perm,int debt, string no)
        {

            string query = string.Format("INSERT INTO StudentsInfo(FirstName,LastName,Email,Telephone,Gender,DepartmentID,ParentName,ParentLastName,ParentTelephone,Address,Discountinuity,Permission,Debt,RoomNo) " + "VALUES('{0}', '{1}', '{2}', '{3}', '{4}', {5}, '{6}', '{7}', '{8}','{9}',{10},{11},{12},'{13}')", fname, lname, email, tel, gender, departmentid, pname, plname, ptel,address,disc,perm,debt, no);
            return DataAccess.ExecuteNonQuery(query);
        }

        public int UpdateStudent(string Id, string fname, string lname, string email, string tel, string pname,string plname, string ptel, string roomno,int depid,string adres)
        {
            int ide = Convert.ToInt32(Id);
            string query = string.Format("UPDATE StudentsInfo SET FirstName = '{0}'," + "LastName ='{1}'," + "Email ='{2}'," + "Telephone ='{3}'," + "ParentName ='{4}'," + "ParentLastName='{5}'," + "ParentTelephone ='{6}',"  + "RoomNo ='{7}'," + "DepartmentID ={8}," + "Address ='{9}'" + "WHERE StudentID = {10} ", fname, lname, email, tel, pname,plname, ptel, roomno, depid,adres,ide);
            return DataAccess.ExecuteNonQuery(query);
        }

       

        public int UpdateStudentr(string fname, string lname, string email, string tel, string gender, int departmentid, string pname,string plname, string ptel,string adress,int disc,int perm,int debt, string roomno)
        {
            string query = string.Format("UPDATE StudentsInfo SET FirstName = '{0}'," + "LastName ='{1}'," + "Email ='{2}'," + "Telephone ='{3}'," + "Gender ='{4}'," + "DepartmentID ={5}," + "ParentName ='{6}'," + "ParentLastName ='{7}'," + "ParentTelephone ='{8}'," + "Address ='{9}'," + "Discountinuity ={10}," + "Permission ={11}," + "Debt ={12}" + "WHERE RoomNo = {13} ", fname, lname, email, tel, gender, departmentid, pname,plname, ptel,adress,disc,perm,debt, roomno);
            return DataAccess.ExecuteNonQuery(query);
        }
        public int DeleteStudent(string id)
        {
            int ide = Convert.ToInt32(id);

            string query = "DELETE  FROM StudentsInfo WHERE StudentID=" + ide;
            return DataAccess.ExecuteNonQuery(query);
        }
        public void odasec(string s)
        {
            
        }
        public DataTable GetAllPayments()
          {
          string query = string.Format("SELECT StudentID, FirstName, LastName, Debt from StudentsInfo");
          return DataAccess.ExecuteQuery(query);
          }
      
        
        public int UpdatePayments(int debt, string idq)
         {
            int ide = Convert.ToInt32(idq);

            string query = string.Format("UPDATE StudentsInfo SET Debt = {0}" + " WHERE StudentID = {1}", debt, ide);
          return DataAccess.ExecuteNonQuery(query);
        }


        public DataTable GetAllAbsenteeism()
        {
            string query = string.Format("SELECT StudentID, FirstName, LastName, Discountinuity from StudentsInfo");
            return DataAccess.ExecuteQuery(query);
        }


        public int UpdateAbsenteeism(int absenteeism, string id)
        {
            int ide = Convert.ToInt32(id);
            
            
            string query = string.Format("UPDATE StudentsInfo SET Discountinuity ={0}" + " WHERE StudentID ={1}",absenteeism, ide);
            return DataAccess.ExecuteNonQuery(query);
        }






    }
}
