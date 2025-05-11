using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace AppQuanLyHocSinh
{
    internal class StudentClass
    {
        DBConnect conn = new DBConnect();

        public bool insertStudent(string fName, string lName, DateTime bdate, string gender, string phone, string address, byte[] img)
        {
            MySqlCommand command = new MySqlCommand("INSERT INTO `student`( `StdFirstName`, `StdLastName`, `BirthDate`, `Gender`, `Phone`, `Address`, `Photo`) VALUES (@fn,@ln,@bd,@gd,@ph,@adr,@img)",conn.getconnection);

            command.Parameters.Add("@fn", MySqlDbType.VarChar).Value = fName;
            command.Parameters.Add("@ln", MySqlDbType.VarChar).Value = lName;
            command.Parameters.Add("@bd", MySqlDbType.Date).Value = bdate;
            command.Parameters.Add("@gd", MySqlDbType.VarChar).Value = gender;
            command.Parameters.Add("@ph", MySqlDbType.VarChar).Value = phone;
            command.Parameters.Add("@adr", MySqlDbType.VarChar).Value = address;
            command.Parameters.Add("@img", MySqlDbType.Blob).Value = img;

            conn.openConnection();
            if (command.ExecuteNonQuery() == 1)
            {
                conn.closeConnection();
                return true;
            }
            else
            {
                conn.closeConnection();
                return false;
            }
        }
        public DataTable getStudentList()
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM `student`", conn.getconnection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public string exeCount(string query)
        {
            MySqlCommand command = new MySqlCommand(query, conn.getconnection);
            conn.openConnection();
            string count = command.ExecuteScalar().ToString();            
            conn.closeConnection();
            return count;
        }

        public string totalStudent()
        {
            string query = "SELECT COUNT(*) FROM student";
            return exeCount(query);
        }

        public string maleStudent() 
        {
            string query = "SELECT COUNT(*) FROM student WHERE `Gender`='Male'";
            return exeCount(query);
        }

        public string femaleStudent()
        {
            string query = "SELECT COUNT(*) FROM student WHERE `Gender`='Female'";
            return exeCount(query);
        }
    }
}
