using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppQuanLyHocSinh
{
    internal class CourseClass
    {
        DBConnect conn = new DBConnect();
        public bool insertCourse(string courseName, int courseHour, string description)
        {
            MySqlCommand command = new MySqlCommand("INSERT INTO `course`(`CourseName`, `CourseHour`, `Description`) VALUES (@cn,@ch,@desc)", conn.getconnection);
            command.Parameters.Add("@cn", MySqlDbType.VarChar).Value = courseName;
            command.Parameters.Add("@ch", MySqlDbType.Int32).Value = courseHour;
            command.Parameters.Add("@desc", MySqlDbType.VarChar).Value = description;
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

        public DataTable getCourseList()
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM `course`", conn.getconnection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public bool updateCourse(int id, string courseName, int courseHour, string description)
        {
            MySqlCommand command = new MySqlCommand("UPDATE `course` SET `CourseName`=@cn,`CourseHour`=@ch,`Description`=@desc WHERE `CourseId`=@id", conn.getconnection);

            command.Parameters.Add("@id", MySqlDbType.Int32).Value = id;
            command.Parameters.Add("@cn", MySqlDbType.VarChar).Value = courseName;
            command.Parameters.Add("@ch", MySqlDbType.Int32).Value = courseHour;
            command.Parameters.Add("@desc", MySqlDbType.VarChar).Value = description;
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

        public bool deleteCourse(int id)
        {
            MySqlCommand command = new MySqlCommand("DELETE FROM `course` WHERE `CourseId`=@id", conn.getconnection);
            command.Parameters.Add("@id", MySqlDbType.Int32).Value = id;
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

        public DataTable searchCourse(string keyword)
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM `course` WHERE CONCAT(`CourseId`, `CourseName`, `CourseHour`, `Description`) LIKE '%" + keyword + "%'", conn.getconnection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

    }
}
