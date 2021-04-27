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
    public partial class AddStudent : Form
    {
        public AddStudent()
        {
            InitializeComponent();
        }

        Student s = new Student();

        private void AddStudent_Load(object sender, EventArgs e)
        {

            //Load Data on Data Grid View

            DataTable dt = s.select();
            dgvStudentList.DataSource = dt;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            
            s.AcademicYearAndSemester = txtBoxAcedemicYearAndSemester.Text;
            s.Programme = txtBoxProgramme.Text;
            s.GroupNumber = (int)GroupNumber.Value;
            s.SubGroupNumber = (int)SubGroupNumber.Value;
            s.GroupId = txtBoxGroupId.Text;
            s.SubGroupId = txtBoxSubGroupId.Text;

            bool Success = s.Insert(s);

            if (Success == true)
            {
                MessageBox.Show("New Student Successfully Inserted");
                clear();
            }

            else
            {
                MessageBox.Show("Failed to Insert Data. Try Again.");
            }

            //Load Data on Data Grid View

            DataTable dt = s.select();
            dgvStudentList.DataSource = dt;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Method to Clear Fields
        public void clear()
        {
            txtBoxStudentId.Text = "";
            txtBoxAcedemicYearAndSemester.Text = "";
            txtBoxProgramme.Text = "";
            GroupNumber.Value = 0;
            SubGroupNumber.Value = 0;  
            txtBoxGroupId.Text = "";
            txtBoxSubGroupId.Text = "";
            

        }

        private void button4_Click(object sender, EventArgs e)
        {
            s.StudentId = int.Parse(txtBoxStudentId.Text);
            s.AcademicYearAndSemester = txtBoxAcedemicYearAndSemester.Text;
            s.Programme = txtBoxProgramme.Text;
            s.GroupNumber = (int)GroupNumber.Value;
            s.SubGroupNumber = (int)SubGroupNumber.Value;
            s.GroupId = txtBoxGroupId.Text;
            s.SubGroupId = txtBoxSubGroupId.Text;

            bool success = s.Update(s);
            if (success == true)
            {
                MessageBox.Show("Student has been Successfully Updated");
            }

            else
            {
                MessageBox.Show("Failed to Update Data. Try Again.");
            }

            //Load Data on Data Grid View

            DataTable dt = s.select();
            dgvStudentList.DataSource = dt;

            clear();
        }

        private void dgvStudentList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvStudentList_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //Get Data from Data Grid View to the Text Boxes
            int rowIndex = e.RowIndex;

            txtBoxStudentId.Text = dgvStudentList.Rows[rowIndex].Cells[0].Value.ToString();
            txtBoxAcedemicYearAndSemester.Text = dgvStudentList.Rows[rowIndex].Cells[1].Value.ToString();
            txtBoxProgramme.Text= dgvStudentList.Rows[rowIndex].Cells[2].Value.ToString();
            GroupNumber.Text = dgvStudentList.Rows[rowIndex].Cells[3].Value.ToString();
            SubGroupNumber.Text = dgvStudentList.Rows[rowIndex].Cells[4].Value.ToString();
            txtBoxGroupId.Text= dgvStudentList.Rows[rowIndex].Cells[5].Value.ToString();
            txtBoxSubGroupId.Text = dgvStudentList.Rows[rowIndex].Cells[6].Value.ToString();
        }

        private void GroupNumber_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //Get the Student Id from the Application

            s.StudentId = Convert.ToInt32(txtBoxStudentId.Text);
            bool Success = s.Delete(s);

            if (Success)
            {
                MessageBox.Show("Student Successfully Deleted");

                //Load Data on Data Grid View

                DataTable dt = s.select();
                dgvStudentList.DataSource = dt;

                //Clear method
                clear();
            }

            else
            {
                MessageBox.Show("Failed to Delete Data. Try Again.");
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomePage back = new HomePage();
            back.Show();
        }

        static string myconnstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;
        private void txtBoxSearch_TextChanged(object sender, EventArgs e)
        {
            //Get the Value from Text Box

            string keyword = txtBoxSearch.Text;
            SqlConnection conn = new SqlConnection(myconnstrng);
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM tbl_student WHERE AcademicYearAndSemester LIKE '%"+keyword+ "%' OR Programme LIKE '%" + keyword + "%' OR GroupId LIKE '%" + keyword + "%' OR SubGroupId LIKE '%" + keyword + "%'",conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dgvStudentList.DataSource = dt;
        }

        private void txtBoxProgramme_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnGenerateId_Click(object sender, EventArgs e)
        {

            
            string a = txtBoxAcedemicYearAndSemester.Text;
            int b = (int)GroupNumber.Value;
            int c = (int)SubGroupNumber.Value;

            string d = a +"."+ b;
            string f = d + "." + c;

            txtBoxGroupId.Text = d;
            txtBoxSubGroupId.Text = f;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblSubGroupNumber_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSave_MouseHover(object sender, EventArgs e)
        {

        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }
    }
}
