using System.Drawing;
using System.Windows.Forms;

namespace labexer7program
{
    partial class FrmUpdateMember
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblStuID2 = new System.Windows.Forms.Label();
            this.cbStudentID2 = new System.Windows.Forms.ComboBox();
            this.lblLastName2 = new System.Windows.Forms.Label();
            this.tbLastName2 = new System.Windows.Forms.TextBox();
            this.tbFirstName2 = new System.Windows.Forms.TextBox();
            this.lblFirstName2 = new System.Windows.Forms.Label();
            this.tbMiddleName2 = new System.Windows.Forms.TextBox();
            this.lblMiddleName2 = new System.Windows.Forms.Label();
            this.tbAge2 = new System.Windows.Forms.TextBox();
            this.lblAge2 = new System.Windows.Forms.Label();
            this.cbGender2 = new System.Windows.Forms.ComboBox();
            this.lblGender2 = new System.Windows.Forms.Label();
            this.cbProgram2 = new System.Windows.Forms.ComboBox();
            this.lblProgram2 = new System.Windows.Forms.Label();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblStuID2
            // 
            this.lblStuID2.AutoSize = true;
            this.lblStuID2.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStuID2.Location = new System.Drawing.Point(12, 12);
            this.lblStuID2.Name = "lblStuID2";
            this.lblStuID2.Size = new System.Drawing.Size(91, 18);
            this.lblStuID2.TabIndex = 0;
            this.lblStuID2.Text = "Student ID:";
            // 
            // cbStudentID2
            // 
            this.cbStudentID2.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbStudentID2.FormattingEnabled = true;
            this.cbStudentID2.Location = new System.Drawing.Point(12, 30);
            this.cbStudentID2.Name = "cbStudentID2";
            this.cbStudentID2.Size = new System.Drawing.Size(211, 26);
            this.cbStudentID2.TabIndex = 1;
            this.cbStudentID2.SelectedIndexChanged += new System.EventHandler(this.cbStudentID2_SelectedIndexChanged);
            // 
            // lblLastName2
            // 
            this.lblLastName2.AutoSize = true;
            this.lblLastName2.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName2.Location = new System.Drawing.Point(12, 59);
            this.lblLastName2.Name = "lblLastName2";
            this.lblLastName2.Size = new System.Drawing.Size(87, 18);
            this.lblLastName2.TabIndex = 2;
            this.lblLastName2.Text = "Last name:";
            // 
            // tbLastName2
            // 
            this.tbLastName2.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbLastName2.Location = new System.Drawing.Point(12, 77);
            this.tbLastName2.Name = "tbLastName2";
            this.tbLastName2.Size = new System.Drawing.Size(211, 26);
            this.tbLastName2.TabIndex = 3;
            // 
            // tbFirstName2
            // 
            this.tbFirstName2.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFirstName2.Location = new System.Drawing.Point(12, 124);
            this.tbFirstName2.Name = "tbFirstName2";
            this.tbFirstName2.Size = new System.Drawing.Size(211, 26);
            this.tbFirstName2.TabIndex = 5;
            // 
            // lblFirstName2
            // 
            this.lblFirstName2.AutoSize = true;
            this.lblFirstName2.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName2.Location = new System.Drawing.Point(12, 106);
            this.lblFirstName2.Name = "lblFirstName2";
            this.lblFirstName2.Size = new System.Drawing.Size(90, 18);
            this.lblFirstName2.TabIndex = 4;
            this.lblFirstName2.Text = "First name:";
            // 
            // tbMiddleName2
            // 
            this.tbMiddleName2.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMiddleName2.Location = new System.Drawing.Point(12, 171);
            this.tbMiddleName2.Name = "tbMiddleName2";
            this.tbMiddleName2.Size = new System.Drawing.Size(211, 26);
            this.tbMiddleName2.TabIndex = 7;
            // 
            // lblMiddleName2
            // 
            this.lblMiddleName2.AutoSize = true;
            this.lblMiddleName2.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMiddleName2.Location = new System.Drawing.Point(12, 153);
            this.lblMiddleName2.Name = "lblMiddleName2";
            this.lblMiddleName2.Size = new System.Drawing.Size(105, 18);
            this.lblMiddleName2.TabIndex = 6;
            this.lblMiddleName2.Text = "Middle name:";
            // 
            // tbAge2
            // 
            this.tbAge2.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAge2.Location = new System.Drawing.Point(12, 218);
            this.tbAge2.Name = "tbAge2";
            this.tbAge2.Size = new System.Drawing.Size(211, 26);
            this.tbAge2.TabIndex = 9;
            // 
            // lblAge2
            // 
            this.lblAge2.AutoSize = true;
            this.lblAge2.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAge2.Location = new System.Drawing.Point(12, 200);
            this.lblAge2.Name = "lblAge2";
            this.lblAge2.Size = new System.Drawing.Size(40, 18);
            this.lblAge2.TabIndex = 8;
            this.lblAge2.Text = "Age:";
            // 
            // cbGender2
            // 
            this.cbGender2.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbGender2.FormattingEnabled = true;
            this.cbGender2.Location = new System.Drawing.Point(12, 265);
            this.cbGender2.Name = "cbGender2";
            this.cbGender2.Size = new System.Drawing.Size(211, 26);
            this.cbGender2.TabIndex = 11;
            // 
            // lblGender2
            // 
            this.lblGender2.AutoSize = true;
            this.lblGender2.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender2.Location = new System.Drawing.Point(12, 247);
            this.lblGender2.Name = "lblGender2";
            this.lblGender2.Size = new System.Drawing.Size(66, 18);
            this.lblGender2.TabIndex = 10;
            this.lblGender2.Text = "Gender:";
            // 
            // cbProgram2
            // 
            this.cbProgram2.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbProgram2.FormattingEnabled = true;
            this.cbProgram2.Location = new System.Drawing.Point(12, 312);
            this.cbProgram2.Name = "cbProgram2";
            this.cbProgram2.Size = new System.Drawing.Size(211, 26);
            this.cbProgram2.TabIndex = 13;
            // 
            // lblProgram2
            // 
            this.lblProgram2.AutoSize = true;
            this.lblProgram2.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProgram2.Location = new System.Drawing.Point(12, 294);
            this.lblProgram2.Name = "lblProgram2";
            this.lblProgram2.Size = new System.Drawing.Size(75, 18);
            this.lblProgram2.TabIndex = 12;
            this.lblProgram2.Text = "Program:";
            // 
            // btnConfirm
            // 
            this.btnConfirm.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.Location = new System.Drawing.Point(75, 344);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(85, 36);
            this.btnConfirm.TabIndex = 14;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // FrmUpdateMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(235, 392);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.cbProgram2);
            this.Controls.Add(this.lblProgram2);
            this.Controls.Add(this.cbGender2);
            this.Controls.Add(this.lblGender2);
            this.Controls.Add(this.tbAge2);
            this.Controls.Add(this.lblAge2);
            this.Controls.Add(this.tbMiddleName2);
            this.Controls.Add(this.lblMiddleName2);
            this.Controls.Add(this.tbFirstName2);
            this.Controls.Add(this.lblFirstName2);
            this.Controls.Add(this.tbLastName2);
            this.Controls.Add(this.lblLastName2);
            this.Controls.Add(this.cbStudentID2);
            this.Controls.Add(this.lblStuID2);
            this.Name = "FrmUpdateMember";
            this.Text = "FrmUpdateMember";
            this.Load += new System.EventHandler(this.FrmUpdateMember_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblStuID2;
        private ComboBox cbStudentID2;
        private Label lblLastName2;
        private TextBox tbLastName2;
        private TextBox tbFirstName2;
        private Label lblFirstName2;
        private TextBox tbMiddleName2;
        private Label lblMiddleName2;
        private TextBox tbAge2;
        private Label lblAge2;
        private ComboBox cbGender2;
        private Label lblGender2;
        private ComboBox cbProgram2;
        private Label lblProgram2;
        private Button btnConfirm;
    }
}