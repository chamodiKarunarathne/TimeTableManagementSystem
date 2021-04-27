using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeTable.TimeTableClasses
{
    class Student
    {
        public int StudentId { get; set; }
        public string AcademicYearAndSemester { get; set; }
        public string Programme { get; set; }
        public int GroupNumber { get; set; }
        public int SubGroupNumber { get; set; }
        public string GroupId { get; set; }
        public string SubGroupId { get; set; }

        static string myconnstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;

        //Select Data From Database

        public DataTable select()
        {
            //Database Connection
            SqlConnection conn = new SqlConnection(myconnstrng);
            DataTable dt = new DataTable();

            try
            {
                string sql = "SELECT * FROM tbl_student";

                SqlCommand cmd = new SqlCommand(sql, conn);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dt);
            }

            catch (Exception ex)
            {

            }

            finally
            {
                conn.Close();
            }
            return dt;
        }

        //Inserting Data Into Database

        public bool Insert(Student s)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnstrng);
            try
            {
                string sql = "INSERT INTO tbl_student(AcademicYearAndSemester, Programme, GroupNumber, SubGroupNumber, GroupId, SubGroupId) VALUES (@AcademicYearAndSemester, @Programme, @GroupNumber, @SubGroupNumber, @GroupId, @SubGroupId)";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@AcademicYearAndSemester", s.AcademicYearAndSemester);
                cmd.Parameters.AddWithValue("@Programme", s.Programme);
                cmd.Parameters.AddWithValue("@GroupNumber", s.GroupNumber);
                cmd.Parameters.AddWithValue("@SubGroupNumber", s.SubGroupNumber);
                cmd.Parameters.AddWithValue("@GroupId", s.GroupId);
                cmd.Parameters.AddWithValue("@SubGroupId", s.SubGroupId);
                

                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }
            }

            catch (Exception ex)
            {

            }

            finally
            {
                conn.Close();
            }
            return isSuccess;
        }


        //Method to  Update Data in Database
        public bool Update(Student s)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnstrng);
            try
            {
                string sql = "UPDATE tbl_student SET AcademicYearAndSemester=@AcademicYearAndSemester, Programme=@Programme, GroupNumber=@GroupNumber, SubGroupNumber=@SubGroupNumber, GroupId=@GroupId, SubGroupId=@SubGroupId WHERE StudentId=@StudentId";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@AcademicYearAndSemester", s.AcademicYearAndSemester);
                cmd.Parameters.AddWithValue("@Programme", s.Programme);
                cmd.Parameters.AddWithValue("@GroupNumber", s.GroupNumber);
                cmd.Parameters.AddWithValue("@SubGroupNumber", s.SubGroupNumber);
                cmd.Parameters.AddWithValue("@GroupId", s.GroupId);
                cmd.Parameters.AddWithValue("@SubGroupId", s.SubGroupId);
                cmd.Parameters.AddWithValue("@StudentId", s.StudentId);

                conn.Open();

                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }
            }

            catch (Exception ex)
            {

            }

            finally
            {

            }

            return isSuccess;
        }


        //Method to Delete Data from the Database

        public bool Delete(Student s)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnstrng);

            try
            {
                string sql = "DELETE FROM tbl_student WHERE StudentId=@StudentId";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@StudentId", s.StudentId);

                conn.Open();

                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }
            }

            catch (Exception ex)
            {

            }

            finally
            {
                conn.Close();
            }

            return isSuccess;
        }

    }
}
