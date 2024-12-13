using System.Drawing;
using System.Windows.Forms;

namespace labexer7program
{
    partial class FrmClubRegistration
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbGender = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbAge = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbMiddleName = new System.Windows.Forms.TextBox();
            this.lblMiddleName = new System.Windows.Forms.Label();
            this.cbProgram = new System.Windows.Forms.ComboBox();
            this.lblProgram = new System.Windows.Forms.Label();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.tbStuID = new System.Windows.Forms.TextBox();
            this.lblStuID = new System.Windows.Forms.Label();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.middleNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.programDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clubMembersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clubDBDataSet = new labexer7program.ClubDBDataSet();
            this.lblClubMember = new System.Windows.Forms.Label();
            this.clubMembersTableAdapter = new labexer7program.ClubDBDataSetTableAdapters.ClubMembersTableAdapter();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clubMembersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clubDBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbGender);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.tbAge);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.tbMiddleName);
            this.panel1.Controls.Add(this.lblMiddleName);
            this.panel1.Controls.Add(this.cbProgram);
            this.panel1.Controls.Add(this.lblProgram);
            this.panel1.Controls.Add(this.tbFirstName);
            this.panel1.Controls.Add(this.lblFirstName);
            this.panel1.Controls.Add(this.tbLastName);
            this.panel1.Controls.Add(this.lblLastName);
            this.panel1.Controls.Add(this.tbStuID);
            this.panel1.Controls.Add(this.lblStuID);
            this.panel1.Font = new System.Drawing.Font("Georgia", 12F);
            this.panel1.Location = new System.Drawing.Point(125, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(389, 157);
            this.panel1.TabIndex = 0;
            // 
            // cbGender
            // 
            this.cbGender.FormattingEnabled = true;
            this.cbGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cbGender.Location = new System.Drawing.Point(135, 128);
            this.cbGender.Name = "cbGender";
            this.cbGender.Size = new System.Drawing.Size(104, 26);
            this.cbGender.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(132, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 18);
            this.label2.TabIndex = 15;
            this.label2.Text = "Gender:";
            // 
            // tbAge
            // 
            this.tbAge.Location = new System.Drawing.Point(6, 128);
            this.tbAge.Name = "tbAge";
            this.tbAge.Size = new System.Drawing.Size(123, 26);
            this.tbAge.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 18);
            this.label1.TabIndex = 13;
            this.label1.Text = "Age:";
            // 
            // tbMiddleName
            // 
            this.tbMiddleName.Location = new System.Drawing.Point(261, 78);
            this.tbMiddleName.Name = "tbMiddleName";
            this.tbMiddleName.Size = new System.Drawing.Size(120, 26);
            this.tbMiddleName.TabIndex = 12;
            // 
            // lblMiddleName
            // 
            this.lblMiddleName.AutoSize = true;
            this.lblMiddleName.Location = new System.Drawing.Point(258, 57);
            this.lblMiddleName.Name = "lblMiddleName";
            this.lblMiddleName.Size = new System.Drawing.Size(105, 18);
            this.lblMiddleName.TabIndex = 11;
            this.lblMiddleName.Text = "Middle name:";
            // 
            // cbProgram
            // 
            this.cbProgram.FormattingEnabled = true;
            this.cbProgram.Items.AddRange(new object[] {
            "BS in Information Technology",
            "BS in Computer Science",
            "BS in Computer Engineering",
            "BS in Tourism Management",
            "BS in Hospitality Management"});
            this.cbProgram.Location = new System.Drawing.Point(184, 28);
            this.cbProgram.Name = "cbProgram";
            this.cbProgram.Size = new System.Drawing.Size(197, 26);
            this.cbProgram.TabIndex = 10;
            // 
            // lblProgram
            // 
            this.lblProgram.AutoSize = true;
            this.lblProgram.Location = new System.Drawing.Point(181, 7);
            this.lblProgram.Name = "lblProgram";
            this.lblProgram.Size = new System.Drawing.Size(75, 18);
            this.lblProgram.TabIndex = 9;
            this.lblProgram.Text = "Program:";
            // 
            // tbFirstName
            // 
            this.tbFirstName.Location = new System.Drawing.Point(135, 78);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(120, 26);
            this.tbFirstName.TabIndex = 8;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(132, 57);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(90, 18);
            this.lblFirstName.TabIndex = 7;
            this.lblFirstName.Text = "First name:";
            // 
            // tbLastName
            // 
            this.tbLastName.Location = new System.Drawing.Point(6, 78);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(123, 26);
            this.tbLastName.TabIndex = 6;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(3, 57);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(87, 18);
            this.lblLastName.TabIndex = 5;
            this.lblLastName.Text = "Last name:";
            // 
            // tbStuID
            // 
            this.tbStuID.Location = new System.Drawing.Point(6, 28);
            this.tbStuID.Name = "tbStuID";
            this.tbStuID.Size = new System.Drawing.Size(172, 26);
            this.tbStuID.TabIndex = 4;
            // 
            // lblStuID
            // 
            this.lblStuID.AutoSize = true;
            this.lblStuID.Location = new System.Drawing.Point(3, 7);
            this.lblStuID.Name = "lblStuID";
            this.lblStuID.Size = new System.Drawing.Size(91, 18);
            this.lblStuID.TabIndex = 3;
            this.lblStuID.Text = "Student ID:";
            // 
            // btnRegister
            // 
            this.btnRegister.Font = new System.Drawing.Font("Georgia", 12F);
            this.btnRegister.Location = new System.Drawing.Point(520, 10);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(90, 41);
            this.btnRegister.TabIndex = 1;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Georgia", 12F);
            this.btnUpdate.Location = new System.Drawing.Point(520, 60);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(90, 41);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnRefresh);
            this.panel2.Controls.Add(this.dataGridView);
            this.panel2.Font = new System.Drawing.Font("Georgia", 12F);
            this.panel2.Location = new System.Drawing.Point(10, 186);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(603, 158);
            this.panel2.TabIndex = 1;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(510, 3);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(90, 41);
            this.btnRefresh.TabIndex = 3;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.AutoGenerateColumns = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.studentIdDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.middleNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.ageDataGridViewTextBoxColumn,
            this.genderDataGridViewTextBoxColumn,
            this.programDataGridViewTextBoxColumn});
            this.dataGridView.DataSource = this.clubMembersBindingSource;
            this.dataGridView.Location = new System.Drawing.Point(2, 3);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(502, 153);
            this.dataGridView.TabIndex = 0;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            // 
            // studentIdDataGridViewTextBoxColumn
            // 
            this.studentIdDataGridViewTextBoxColumn.DataPropertyName = "StudentId";
            this.studentIdDataGridViewTextBoxColumn.HeaderText = "StudentId";
            this.studentIdDataGridViewTextBoxColumn.Name = "studentIdDataGridViewTextBoxColumn";
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            // 
            // middleNameDataGridViewTextBoxColumn
            // 
            this.middleNameDataGridViewTextBoxColumn.DataPropertyName = "MiddleName";
            this.middleNameDataGridViewTextBoxColumn.HeaderText = "MiddleName";
            this.middleNameDataGridViewTextBoxColumn.Name = "middleNameDataGridViewTextBoxColumn";
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "LastName";
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            // 
            // ageDataGridViewTextBoxColumn
            // 
            this.ageDataGridViewTextBoxColumn.DataPropertyName = "Age";
            this.ageDataGridViewTextBoxColumn.HeaderText = "Age";
            this.ageDataGridViewTextBoxColumn.Name = "ageDataGridViewTextBoxColumn";
            // 
            // genderDataGridViewTextBoxColumn
            // 
            this.genderDataGridViewTextBoxColumn.DataPropertyName = "Gender";
            this.genderDataGridViewTextBoxColumn.HeaderText = "Gender";
            this.genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            // 
            // programDataGridViewTextBoxColumn
            // 
            this.programDataGridViewTextBoxColumn.DataPropertyName = "Program";
            this.programDataGridViewTextBoxColumn.HeaderText = "Program";
            this.programDataGridViewTextBoxColumn.Name = "programDataGridViewTextBoxColumn";
            // 
            // clubMembersBindingSource
            // 
            this.clubMembersBindingSource.DataMember = "ClubMembers";
            this.clubMembersBindingSource.DataSource = this.clubDBDataSet;
            // 
            // clubDBDataSet
            // 
            this.clubDBDataSet.DataSetName = "ClubDBDataSet";
            this.clubDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblClubMember
            // 
            this.lblClubMember.AutoSize = true;
            this.lblClubMember.Font = new System.Drawing.Font("Georgia", 12F);
            this.lblClubMember.Location = new System.Drawing.Point(13, 170);
            this.lblClubMember.Name = "lblClubMember";
            this.lblClubMember.Size = new System.Drawing.Size(160, 18);
            this.lblClubMember.TabIndex = 0;
            this.lblClubMember.Text = "List of Club Members";
            // 
            // clubMembersTableAdapter
            // 
            this.clubMembersTableAdapter.ClearBeforeFill = true;
            // 
            // FrmClubRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 356);
            this.Controls.Add(this.lblClubMember);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.panel1);
            this.Name = "FrmClubRegistration";
            this.Text = "FrmClubRegistration";
            this.Load += new System.EventHandler(this.FrmClubRegistration_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clubMembersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clubDBDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Button btnRegister;
        private Button btnUpdate;
        private Label lblProgram;
        private TextBox tbFirstName;
        private Label lblFirstName;
        private TextBox tbLastName;
        private Label lblLastName;
        private TextBox tbStuID;
        private Label lblStuID;
        private Label lblClubMember;
        private TextBox tbAge;
        private Label label1;
        private TextBox tbMiddleName;
        private Label lblMiddleName;
        private ComboBox cbProgram;
        private DataGridView dataGridView;
        private ClubDBDataSet clubDBDataSet;
        private BindingSource clubMembersBindingSource;
        private ClubDBDataSetTableAdapters.ClubMembersTableAdapter clubMembersTableAdapter;
        private DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn studentIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn middleNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn ageDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn programDataGridViewTextBoxColumn;
        private Button btnRefresh;
        private ComboBox cbGender;
        private Label label2;
    }
}

