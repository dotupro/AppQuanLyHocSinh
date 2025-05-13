using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppQuanLyHocSinh
{
    internal class ScoreClass
    {
        DBConnect conn = new DBConnect();
        public bool insertScore(int studentId, string courseName, double score, string desc)
        {
            MySqlCommand command = new MySqlCommand("INSERT INTO `score`(`StudentId`, `CourseName`, `Score`, `Description`) VALUES (@stdid,@cn,@sc,@desc)", conn.getconnection);
            command.Parameters.Add("@stdid", MySqlDbType.VarChar).Value = studentId;
            command.Parameters.Add("@cn", MySqlDbType.VarChar).Value = courseName;
            command.Parameters.Add("@sc", MySqlDbType.Double).Value = score;
            command.Parameters.Add("@desc", MySqlDbType.VarChar).Value = desc;
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

        public DataTable getScoreList()
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM `score`", conn.getconnection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public bool checkScore(int studentId, string courseName)
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM `score` WHERE `StudentId`= '"+ studentId +"' AND `CourseName`= '"+ courseName +"'", conn.getconnection);        
            DataTable table = new DataTable();
            if (table.Rows.Count > 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool updateScore(int studentId, string courseName, double score, string desc)
        {
            MySqlCommand command = new MySqlCommand("UPDATE `score` SET `Score`=@sc,`Description`=@desc WHERE `StudentId`='"+ studentId +"' AND `CourseName`=@cn", conn.getconnection);
            command.Parameters.Add("@cn", MySqlDbType.VarChar).Value = courseName;
            command.Parameters.Add("@sc", MySqlDbType.Double).Value = score;
            command.Parameters.Add("@desc", MySqlDbType.VarChar).Value = desc;
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

        public bool deleteScore(int studentId, string courseName)
        {
            MySqlCommand command = new MySqlCommand("DELETE FROM `score` WHERE `StudentId`= '" + studentId + "' AND `CourseName`= '" + courseName + "'", conn.getconnection);
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
        public DataTable searchScore(string searchValue)
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM `score` WHERE CONCAT(`StudentId`, `CourseName`, `Score`, `Description`) LIKE '%" + searchValue + "%'", conn.getconnection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }


    }
}
