using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace CMPE214_Project
{
    public partial class FormAdd : Form
    {
        int id;
        public FormAdd()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.txtAddName.Clear();
            this.txtAddSurname.Clear();
            this.txtAddPass.Clear();
            this.comboAddN.SelectedIndex = -1;
            this.comboAddDept.SelectedIndex = -1;
            this.dateTimePicker1.Value = DateTimePicker.MinimumDateTime;
            this.dateTimePicker2.Value = DateTimePicker.MinimumDateTime;
            this.errorProvider.Clear();
        }

        private void FormAdd_Load(object sender, EventArgs e)
        {
            this.AcceptButton = btnAdd;

            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "ddd dd MM yy";

            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.CustomFormat = "ddd dd MM yy";
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            //mainForm f1 = new mainForm();
            //f1.Show();
            this.Close();
            //mainform_refresh)();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (areFieldsValidated())
            {
                String name = this.txtAddName.Text;
                String surname = this.txtAddSurname.Text;
                String nationality = this.comboAddN.Text;
                String passNo = this.txtAddPass.Text;
                DateTime DOB = this.dateTimePicker1.Value;
                String department = this.comboAddDept.Text;
                DateTime DOR = this.dateTimePicker2.Value;
                String gender = "";
                if (radioMale.Checked)
                    gender = radioMale.Text;
                else if (radioFemale.Checked)
                    gender = radioFemale.Text;

                string lastId = "";

                var doc = XDocument.Load(@"C:\Project XML Files\records.xml");

                XElement studentss = XElement.Load(@"C:\Project XML Files\records.xml");

                foreach (var node in studentss.Elements("student").Elements("id"))
                {
                    lastId = node.Value;
                }

                id = Convert.ToInt32(lastId.ToString());
                ++id;

                var newElement = new XElement("student",
                new XElement("id", id),
                new XElement("name", name),
                new XElement("surname", surname),
                new XElement("gender", gender),
                new XElement("nationality", nationality),
                new XElement("passNo", passNo),
                new XElement("DOB", DOB.ToShortDateString()),
                new XElement("department", department),
                new XElement("DOR", DOR.ToShortDateString())
                );
                
                doc.Element("students").Add(newElement);
                doc.Save(@"C:\Project XML Files\records.xml");

                MessageBox.Show("Data is added to XML");

            }
        }

        private bool areFieldsValidated()
        {
            bool isValidated = true;

            if (txtAddName.Text.Length < 1)
            {
                errorProvider.SetError(txtAddName, "Please fill in the name");
                isValidated = false;
            }

            else if (txtAddSurname.Text.Length < 1)
            {
                errorProvider.SetError(txtAddSurname, "Please fill in the surname");
                isValidated = false;
            }

            else if (!radioMale .Checked && !radioFemale.Checked)
            {
                errorProvider.SetError(lblAddGender, "Please Select a gender");
                isValidated = false;
            }

            else if (comboAddN.SelectedIndex == -1)
            {
                errorProvider.SetError(comboAddN, "Please select a department");
                isValidated = false;
            }

            else if (txtAddPass.Text.Length < 1)
            {
                errorProvider.SetError(txtAddPass, "Please fill in the passport number");
                isValidated = false;
            }

            else if (dateTimePicker1.Value == DateTimePicker.MinimumDateTime)
            {
                errorProvider.SetError(dateTimePicker1, "Please select a date");
                isValidated = false;
            }

            else if (comboAddDept.Text.Length < 1)
            {
                errorProvider.SetError(comboAddDept, "Please select a department");
                isValidated = false;
            }

            else if (dateTimePicker2.Value == DateTimePicker.MinimumDateTime)
            {
                errorProvider.SetError(dateTimePicker2, "Please select a date");
                isValidated = false;
            }

            return isValidated;
        }
    }
}
