namespace CMPE214_Project
{
    partial class FormUpdate
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
            this.components = new System.ComponentModel.Container();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker2Upd = new System.Windows.Forms.DateTimePicker();
            this.btnBack = new System.Windows.Forms.Button();
            this.dateTimePicker1Upd = new System.Windows.Forms.DateTimePicker();
            this.comboUpdN = new System.Windows.Forms.ComboBox();
            this.txtUpdSurname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.comboUpdDept = new System.Windows.Forms.ComboBox();
            this.txtUpdPass = new System.Windows.Forms.TextBox();
            this.txtUpdName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblUpdID = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.radioFemale = new System.Windows.Forms.RadioButton();
            this.radioMale = new System.Windows.Forms.RadioButton();
            this.lblUpdGender = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioFemale);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.radioMale);
            this.groupBox2.Controls.Add(this.lblUpdID);
            this.groupBox2.Controls.Add(this.lblUpdGender);
            this.groupBox2.Controls.Add(this.dateTimePicker2Upd);
            this.groupBox2.Controls.Add(this.btnBack);
            this.groupBox2.Controls.Add(this.dateTimePicker1Upd);
            this.groupBox2.Controls.Add(this.comboUpdN);
            this.groupBox2.Controls.Add(this.txtUpdSurname);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.btnClear);
            this.groupBox2.Controls.Add(this.btnUpdate);
            this.groupBox2.Controls.Add(this.comboUpdDept);
            this.groupBox2.Controls.Add(this.txtUpdPass);
            this.groupBox2.Controls.Add(this.txtUpdName);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(740, 375);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Update Student Info ";
            // 
            // dateTimePicker2Upd
            // 
            this.dateTimePicker2Upd.Location = new System.Drawing.Point(260, 262);
            this.dateTimePicker2Upd.Name = "dateTimePicker2Upd";
            this.dateTimePicker2Upd.Size = new System.Drawing.Size(290, 26);
            this.dateTimePicker2Upd.TabIndex = 18;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(124, 316);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(187, 53);
            this.btnBack.TabIndex = 17;
            this.btnBack.Text = "Main Interface";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // dateTimePicker1Upd
            // 
            this.dateTimePicker1Upd.Location = new System.Drawing.Point(235, 185);
            this.dateTimePicker1Upd.Name = "dateTimePicker1Upd";
            this.dateTimePicker1Upd.Size = new System.Drawing.Size(290, 26);
            this.dateTimePicker1Upd.TabIndex = 16;
            // 
            // comboUpdN
            // 
            this.comboUpdN.FormattingEnabled = true;
            this.comboUpdN.Items.AddRange(new object[] {
            "American",
            "Cypriot",
            "Egyptian",
            "English",
            "Turkish"});
            this.comboUpdN.Location = new System.Drawing.Point(235, 114);
            this.comboUpdN.Name = "comboUpdN";
            this.comboUpdN.Size = new System.Drawing.Size(290, 26);
            this.comboUpdN.TabIndex = 15;
            // 
            // txtUpdSurname
            // 
            this.txtUpdSurname.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtUpdSurname.Location = new System.Drawing.Point(235, 75);
            this.txtUpdSurname.Name = "txtUpdSurname";
            this.txtUpdSurname.Size = new System.Drawing.Size(290, 26);
            this.txtUpdSurname.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(85, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 18);
            this.label4.TabIndex = 13;
            this.label4.Text = "Nationality:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(85, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 18);
            this.label3.TabIndex = 12;
            this.label3.Text = "Passport Number:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(85, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 18);
            this.label2.TabIndex = 11;
            this.label2.Text = "Date Of Birth:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(82, 262);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 18);
            this.label1.TabIndex = 10;
            this.label1.Text = "Date of Registeration:";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(317, 316);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(187, 53);
            this.btnClear.TabIndex = 9;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(510, 316);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(187, 53);
            this.btnUpdate.TabIndex = 8;
            this.btnUpdate.Text = "Update Student";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // comboUpdDept
            // 
            this.comboUpdDept.FormattingEnabled = true;
            this.comboUpdDept.Items.AddRange(new object[] {
            "Computer Engineering",
            "Electrical Engineering",
            "Mechanical Engineering",
            "Checmical Engineering",
            "Information & Technology Systems Management",
            "Pharmacy"});
            this.comboUpdDept.Location = new System.Drawing.Point(235, 220);
            this.comboUpdDept.Name = "comboUpdDept";
            this.comboUpdDept.Size = new System.Drawing.Size(290, 26);
            this.comboUpdDept.TabIndex = 7;
            // 
            // txtUpdPass
            // 
            this.txtUpdPass.Location = new System.Drawing.Point(235, 152);
            this.txtUpdPass.Name = "txtUpdPass";
            this.txtUpdPass.Size = new System.Drawing.Size(290, 26);
            this.txtUpdPass.TabIndex = 6;
            // 
            // txtUpdName
            // 
            this.txtUpdName.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtUpdName.Location = new System.Drawing.Point(235, 39);
            this.txtUpdName.Name = "txtUpdName";
            this.txtUpdName.Size = new System.Drawing.Size(290, 26);
            this.txtUpdName.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(82, 223);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 18);
            this.label6.TabIndex = 3;
            this.label6.Text = "DEPARTMENT:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(85, 75);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 18);
            this.label7.TabIndex = 2;
            this.label7.Text = "SURNAME:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(85, 39);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 18);
            this.label8.TabIndex = 1;
            this.label8.Text = "NAME:";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // lblUpdID
            // 
            this.lblUpdID.AutoSize = true;
            this.lblUpdID.Location = new System.Drawing.Point(269, 18);
            this.lblUpdID.Name = "lblUpdID";
            this.lblUpdID.Size = new System.Drawing.Size(48, 18);
            this.lblUpdID.TabIndex = 19;
            this.lblUpdID.Text = "<ID>";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(232, 18);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 18);
            this.label9.TabIndex = 20;
            this.label9.Text = "ID:";
            // 
            // radioFemale
            // 
            this.radioFemale.AutoSize = true;
            this.radioFemale.Location = new System.Drawing.Point(635, 78);
            this.radioFemale.Name = "radioFemale";
            this.radioFemale.Size = new System.Drawing.Size(80, 22);
            this.radioFemale.TabIndex = 24;
            this.radioFemale.TabStop = true;
            this.radioFemale.Text = "Female";
            this.radioFemale.UseVisualStyleBackColor = true;
            // 
            // radioMale
            // 
            this.radioMale.AutoSize = true;
            this.radioMale.Location = new System.Drawing.Point(635, 46);
            this.radioMale.Name = "radioMale";
            this.radioMale.Size = new System.Drawing.Size(60, 22);
            this.radioMale.TabIndex = 23;
            this.radioMale.TabStop = true;
            this.radioMale.Text = "Male";
            this.radioMale.UseVisualStyleBackColor = true;
            // 
            // lblUpdGender
            // 
            this.lblUpdGender.AutoSize = true;
            this.lblUpdGender.Location = new System.Drawing.Point(560, 46);
            this.lblUpdGender.Name = "lblUpdGender";
            this.lblUpdGender.Size = new System.Drawing.Size(69, 18);
            this.lblUpdGender.TabIndex = 22;
            this.lblUpdGender.Text = "Gender:";
            // 
            // FormUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Name = "FormUpdate";
            this.Text = "FormUpdate";
            this.Load += new System.EventHandler(this.FormUpdate_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.DateTimePicker dateTimePicker2Upd;
        private System.Windows.Forms.Button btnBack;
        public System.Windows.Forms.DateTimePicker dateTimePicker1Upd;
        public System.Windows.Forms.ComboBox comboUpdN;
        public System.Windows.Forms.TextBox txtUpdSurname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnUpdate;
        public System.Windows.Forms.ComboBox comboUpdDept;
        public System.Windows.Forms.TextBox txtUpdPass;
        public System.Windows.Forms.TextBox txtUpdName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.Label lblUpdID;
        private System.Windows.Forms.Label lblUpdGender;
        public System.Windows.Forms.RadioButton radioFemale;
        public System.Windows.Forms.RadioButton radioMale;
    }
}