using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace labexer7program
{
    public partial class FrmClubRegistration : Form
    {
        FrmUpdateMember form2 = new FrmUpdateMember();
        private ClubRegistrationQuery clubRegistrationQuery = new ClubRegistrationQuery();
        private int ID, Age, count;
        private string FirstName, MiddleName, LastName, Gender, Program;
        private long StudentId;

        private void btnRegister_Click(object sender, EventArgs e)
        {
            ID = RegistrationID();
            StudentId = Convert.ToInt32(tbStuID.Text);
            FirstName = tbFirstName.Text;
            MiddleName = tbMiddleName.Text;
            LastName = tbLastName.Text;
            Age = Convert.ToInt32(tbAge.Text);
            Gender = cbGender.Text;
            Program = cbProgram.Text;
            clubRegistrationQuery.RegisterStudent(ID, StudentId, FirstName, MiddleName, LastName, Age, Gender, Program);
            RegistrationID();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            form2.Show();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshListOfClubMembers();
        }

        private void FrmClubRegistration_Load(object sender, EventArgs e)
        {
            RefreshListOfClubMembers();
            countID();
        }
        public FrmClubRegistration()
        {
            InitializeComponent();
        }
        public void RefreshListOfClubMembers()
        {
            clubRegistrationQuery.DisplayList();
            dataGridView.DataSource = clubRegistrationQuery.bindingSource;
        }
        public int RegistrationID()
        {
            count++;
            return count;
        }
        public void countID()
        {
            string commandCount = "SELECT COUNT(ID) FROM ClubMembers";
            string connect = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=F:\\Program\\c#\\EmployeeApplication\\labexer7program\\ClubDB.mdf;Integrated Security=True";
            using (SqlConnection sqlCon = new SqlConnection(connect))
            {
                using (SqlCommand cmd = new SqlCommand(commandCount, sqlCon))
                {
                    sqlCon.Open();
                    count = (int)cmd.ExecuteScalar();
                }
            }
        }
    }
}
