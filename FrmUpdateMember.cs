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
using System.Data;
using System.Data.SqlClient;

namespace labexer7program
{
    public partial class FrmUpdateMember : Form
    {
        private static string connect = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=F:\\Program\\c#\\EmployeeApplication\\labexer7program\\ClubDB.mdf;Integrated Security=True";
        SqlConnection conn = new SqlConnection(connect);
        SqlDataReader reader;
        public FrmUpdateMember()
        {
            InitializeComponent();
        }

        private void FrmUpdateMember_Load(object sender, EventArgs e)
        {
            
            string selectStuID = "SELECT StudentId FROM ClubMembers";
            SqlCommand selId = new SqlCommand(selectStuID, conn);
            conn.Open();
            reader = selId.ExecuteReader();
            while (reader.Read())
            {
                cbStudentID2.Items.Add(reader["StudentId"].ToString());
            }
            conn.Close();
        }

        private void cbStudentID2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectInfo = "SELECT FirstName, MiddleName, LastName, Age, Gender, Program FROM ClubMembers WHERE StudentId = @ID ";
            SqlCommand selInfo = new SqlCommand(selectInfo, conn);
            selInfo.Parameters.Add("@ID", SqlDbType.Int).Value = Convert.ToInt32(cbStudentID2.Text);
            conn.Open();
            reader = selInfo.ExecuteReader();
            while (reader.Read())
            {
                tbFirstName2.Text = (reader["FirstName"].ToString());
                tbLastName2.Text = (reader["LastName"].ToString());
                tbMiddleName2.Text = (reader["MiddleName"].ToString());
                tbAge2.Text = (reader["Age"].ToString());
                cbGender2.Text = (reader["Gender"].ToString());
                cbProgram2.Text = (reader["Program"].ToString());
            }
            conn.Close();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            string selectStuID = "SELECT StudentId FROM ClubMembers";
            SqlCommand selId = new SqlCommand(selectStuID, conn);
            SqlCommand update = new SqlCommand("UPDATE ClubMembers SET FirstName = @FirstName,MiddleName = @MiddleName,LastName= @LastName,Age= @Age,Gender= @Gender,Program= @Program WHERE StudentId = @StudentID", conn);
            update.Parameters.Add("@StudentID", SqlDbType.BigInt).Value = Convert.ToInt32(cbStudentID2.Text);
            update.Parameters.Add("@FirstName", SqlDbType.VarChar).Value = tbFirstName2.Text;
            update.Parameters.Add("@MiddleName", SqlDbType.VarChar).Value = tbMiddleName2.Text;
            update.Parameters.Add("@LastName", SqlDbType.VarChar).Value = tbLastName2.Text;
            update.Parameters.Add("@Age", SqlDbType.Int).Value = Convert.ToInt32(tbAge2.Text);
            update.Parameters.Add("@Gender", SqlDbType.VarChar).Value = cbGender2.Text;
            update.Parameters.Add("@Program", SqlDbType.VarChar).Value = cbProgram2.Text;
            conn.Open();
            update.ExecuteNonQuery();
            reader = selId.ExecuteReader();
            while (reader.Read())
            {
                cbStudentID2.Items.Add(reader["StudentId"].ToString());
            }
            conn.Close();
            Hide();
        }
    }
}
