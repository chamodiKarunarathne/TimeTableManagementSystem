using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TimeTable.TimeTableClasses;

namespace TimeTable
{
    public partial class ManageTags : Form
    {
        public ManageTags()
        {
            InitializeComponent();
        }

        Tag t = new Tag();

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            t.TagName = txtBoxTagName.Text;
            t.TagCode = txtBoxTagCode.Text;
            t.RelatedTag = txtBoxRelatedTag.Text;
            

            bool Success = t.Insert(t);

            if (Success == true)
            {
                MessageBox.Show("New Tag Successfully Inserted");
                clear();

            }

            else
            {
                MessageBox.Show("Failed to Insert Data. Try Again.");
            }

            //Load Data on Data Grid View

            DataTable dt = t.select();
            dgvTagList.DataSource = dt;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
        }
    

    //Method to Clear Fields
    public void clear()
        {
            txtBoxTagName.Text = "";
            txtBoxTagCode.Text = "";
            txtBoxRelatedTag.Text = "";
            


        }

        private void ManageTags_Load(object sender, EventArgs e)
        {

            //Load Data on Data Grid View

            DataTable dt = t.select();
            dgvTagList.DataSource = dt;

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            t.TagId = int.Parse(txtBoxTagId.Text);
            t.TagName = txtBoxTagName.Text;
            t.TagCode = txtBoxTagCode.Text;
            t.RelatedTag = txtBoxRelatedTag.Text;

            bool success = t.Update(t);
            if (success == true)
            {
                MessageBox.Show("Tag has been Successfully Updated");
            }

            else
            {
                MessageBox.Show("Failed to Update Data. Try Again.");
            }

            //Load Data on Data Grid View

            DataTable dt = t.select();
            dgvTagList.DataSource = dt;

            clear();
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void dgvTagList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvTagList_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //Get Data from Data Grid View to the Text Boxes
            int rowIndex = e.RowIndex;

            txtBoxTagId.Text = dgvTagList.Rows[rowIndex].Cells[0].Value.ToString();
            txtBoxTagName.Text = dgvTagList.Rows[rowIndex].Cells[1].Value.ToString();
            txtBoxTagCode.Text = dgvTagList.Rows[rowIndex].Cells[2].Value.ToString();
            txtBoxRelatedTag.Text = dgvTagList.Rows[rowIndex].Cells[3].Value.ToString();
            
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            //Get the Student Id from the Application

            t.TagId = Convert.ToInt32(txtBoxTagId.Text);
            bool Success = t.Delete(t);

            if (Success)
            {
                MessageBox.Show("Tag Successfully Deleted");

                //Load Data on Data Grid View

                DataTable dt = t.select();
                dgvTagList.DataSource = dt;

                //Clear method
                clear();
            }

            else
            {
                MessageBox.Show("Failed to Delete Data. Try Again.");
            }
        }


        static string myconnstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;
        private void txtBoxSearch_TextChanged(object sender, EventArgs e)
        {
            //Get the Value from Text Box

            string keyword = txtBoxSearch.Text;
            SqlConnection conn = new SqlConnection(myconnstrng);
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM tbl_tag WHERE TagName LIKE '%" + keyword + "%' OR TagCode LIKE '%" + keyword + "%' OR RelatedTag LIKE '%" + keyword + "%'", conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dgvTagList.DataSource = dt;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomePage back = new HomePage();
            back.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
