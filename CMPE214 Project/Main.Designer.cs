namespace CMPE214_Project
{
    partial class mainForm
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnXcreate = new System.Windows.Forms.Button();
            this.lbl_DOR = new System.Windows.Forms.Label();
            this.lbl_DOB = new System.Windows.Forms.Label();
            this.lbl_dep = new System.Windows.Forms.Label();
            this.lbl_pass = new System.Windows.Forms.Label();
            this.lbl_nationality = new System.Windows.Forms.Label();
            this.lbl_surname = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            this.lbl_ID = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnRead = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.lblGender = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.AutoSize = true;
            this.groupBox2.Controls.Add(this.lblGender);
            this.groupBox2.Controls.Add(this.btnXcreate);
            this.groupBox2.Controls.Add(this.lbl_DOR);
            this.groupBox2.Controls.Add(this.lbl_DOB);
            this.groupBox2.Controls.Add(this.lbl_dep);
            this.groupBox2.Controls.Add(this.lbl_pass);
            this.groupBox2.Controls.Add(this.lbl_nationality);
            this.groupBox2.Controls.Add(this.lbl_surname);
            this.groupBox2.Controls.Add(this.lbl_name);
            this.groupBox2.Controls.Add(this.lbl_ID);
            this.groupBox2.Controls.Add(this.listView1);
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.btnRead);
            this.groupBox2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Blue;
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(990, 321);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Read Present Records";
            // 
            // btnXcreate
            // 
            this.btnXcreate.Location = new System.Drawing.Point(46, 31);
            this.btnXcreate.Name = "btnXcreate";
            this.btnXcreate.Size = new System.Drawing.Size(174, 50);
            this.btnXcreate.TabIndex = 23;
            this.btnXcreate.Text = "Create XML doc";
            this.btnXcreate.UseVisualStyleBackColor = true;
            this.btnXcreate.Click += new System.EventHandler(this.btnXcreate_Click);
            // 
            // lbl_DOR
            // 
            this.lbl_DOR.AutoSize = true;
            this.lbl_DOR.Location = new System.Drawing.Point(639, 239);
            this.lbl_DOR.Name = "lbl_DOR";
            this.lbl_DOR.Size = new System.Drawing.Size(211, 18);
            this.lbl_DOR.TabIndex = 22;
            this.lbl_DOR.Text = "<Date of Registeration>";
            // 
            // lbl_DOB
            // 
            this.lbl_DOB.AutoSize = true;
            this.lbl_DOB.Location = new System.Drawing.Point(638, 203);
            this.lbl_DOB.Name = "lbl_DOB";
            this.lbl_DOB.Size = new System.Drawing.Size(143, 18);
            this.lbl_DOB.TabIndex = 21;
            this.lbl_DOB.Text = "<Date Of Birth>";
            // 
            // lbl_dep
            // 
            this.lbl_dep.AutoSize = true;
            this.lbl_dep.Location = new System.Drawing.Point(638, 221);
            this.lbl_dep.Name = "lbl_dep";
            this.lbl_dep.Size = new System.Drawing.Size(131, 18);
            this.lbl_dep.TabIndex = 20;
            this.lbl_dep.Text = "<Department>";
            // 
            // lbl_pass
            // 
            this.lbl_pass.AutoSize = true;
            this.lbl_pass.Location = new System.Drawing.Point(638, 185);
            this.lbl_pass.Name = "lbl_pass";
            this.lbl_pass.Size = new System.Drawing.Size(165, 18);
            this.lbl_pass.TabIndex = 19;
            this.lbl_pass.Text = "<Pasport Number>";
            // 
            // lbl_nationality
            // 
            this.lbl_nationality.AutoSize = true;
            this.lbl_nationality.Location = new System.Drawing.Point(638, 167);
            this.lbl_nationality.Name = "lbl_nationality";
            this.lbl_nationality.Size = new System.Drawing.Size(124, 18);
            this.lbl_nationality.TabIndex = 18;
            this.lbl_nationality.Text = "<Nationality>";
            // 
            // lbl_surname
            // 
            this.lbl_surname.AutoSize = true;
            this.lbl_surname.Location = new System.Drawing.Point(638, 149);
            this.lbl_surname.Name = "lbl_surname";
            this.lbl_surname.Size = new System.Drawing.Size(115, 18);
            this.lbl_surname.TabIndex = 17;
            this.lbl_surname.Text = "<Sunrname>";
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Location = new System.Drawing.Point(638, 131);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(81, 18);
            this.lbl_name.TabIndex = 16;
            this.lbl_name.Text = "<Name>";
            // 
            // lbl_ID
            // 
            this.lbl_ID.AutoSize = true;
            this.lbl_ID.Location = new System.Drawing.Point(638, 113);
            this.lbl_ID.Name = "lbl_ID";
            this.lbl_ID.Size = new System.Drawing.Size(117, 18);
            this.lbl_ID.TabIndex = 15;
            this.lbl_ID.Text = "<StudentID>";
            // 
            // listView1
            // 
            this.listView1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listView1.Location = new System.Drawing.Point(6, 87);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(519, 208);
            this.listView1.TabIndex = 14;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(850, 113);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(134, 182);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(544, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(200, 18);
            this.label4.TabIndex = 12;
            this.label4.Text = "Selected  Student Info:";
            // 
            // btnRead
            // 
            this.btnRead.Location = new System.Drawing.Point(313, 31);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(174, 50);
            this.btnRead.TabIndex = 7;
            this.btnRead.Text = "Load All Students Records";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.AutoSize = true;
            this.btnDelete.ForeColor = System.Drawing.Color.Black;
            this.btnDelete.Location = new System.Drawing.Point(108, 59);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(217, 50);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Delete Student Record";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnDelete);
            this.groupBox3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox3.ForeColor = System.Drawing.Color.Blue;
            this.groupBox3.Location = new System.Drawing.Point(12, 339);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(447, 159);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Delete A Record";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(482, 339);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(187, 53);
            this.btnUpdate.TabIndex = 9;
            this.btnUpdate.Text = "Update Record";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(675, 339);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(187, 53);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "Add Record";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnAdmin
            // 
            this.btnAdmin.Location = new System.Drawing.Point(587, 398);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(187, 53);
            this.btnAdmin.TabIndex = 11;
            this.btnAdmin.Text = "Admin Login";
            this.btnAdmin.UseVisualStyleBackColor = true;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(815, 445);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(187, 53);
            this.btnRefresh.TabIndex = 12;
            this.btnRefresh.Text = "Refresh Form";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(639, 257);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(92, 18);
            this.lblGender.TabIndex = 24;
            this.lblGender.Text = "<Gender>";
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1011, 513);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnAdmin);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Name = "mainForm";
            this.Text = "Main Form";
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnAdmin;
        private System.Windows.Forms.Label lbl_DOR;
        private System.Windows.Forms.Label lbl_DOB;
        private System.Windows.Forms.Label lbl_dep;
        private System.Windows.Forms.Label lbl_pass;
        private System.Windows.Forms.Label lbl_nationality;
        private System.Windows.Forms.Label lbl_surname;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label lbl_ID;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button btnXcreate;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label lblGender;
    }
}

