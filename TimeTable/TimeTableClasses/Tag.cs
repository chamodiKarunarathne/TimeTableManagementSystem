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
    class Tag
    {

        public int TagId { get; set; }
        public string TagName { get; set; }
        public string TagCode { get; set; }
        public string RelatedTag { get; set; }
        

        static string myconnstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;

        //Select Data From Database

        public DataTable select()
        {
            //Database Connection
            SqlConnection conn = new SqlConnection(myconnstrng);
            DataTable dt = new DataTable();

            try
            {
                string sql = "SELECT * FROM tbl_tag";

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

        public bool Insert(Tag t)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnstrng);
            try
            {
                string sql = "INSERT INTO tbl_tag(TagName, TagCode, RelatedTag) VALUES (@TagName, @TagCode, @RelatedTag)";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@TagName", t.TagName);
                cmd.Parameters.AddWithValue("@TagCode", t.TagCode);
                cmd.Parameters.AddWithValue("@RelatedTag", t.RelatedTag);
                
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
        public bool Update(Tag t)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnstrng);
            try
            {
                string sql = "UPDATE tbl_tag SET TagName = @TagName, TagCode = @TagCode, RelatedTag = @RelatedTag WHERE TagId = @TagId";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@TagName", t.TagName);
                cmd.Parameters.AddWithValue("@TagCode", t.TagCode);
                cmd.Parameters.AddWithValue("@RelatedTag", t.RelatedTag);
                cmd.Parameters.AddWithValue("@TagId", t.TagId);

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

        public bool Delete(Tag t)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnstrng);

            try
            {
                string sql = "DELETE FROM tbl_tag WHERE TagId= @TagId";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@TagId", t.TagId);

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
