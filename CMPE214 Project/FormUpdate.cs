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
    public partial class FormUpdate : Form
    {
        private mainForm _ParentForm;

        public FormUpdate(mainForm parentForm)
        {
            InitializeComponent();
            _ParentForm = parentForm; 
        }

        public static implicit operator FormUpdate(FormAdd v)
        {
            throw new NotImplementedException();
        }

        private void FormUpdate_Load(object sender, EventArgs e)
        {
            this.AcceptButton = btnUpdate;

            dateTimePicker1Upd.Format = DateTimePickerFormat.Custom;
            dateTimePicker1Upd.CustomFormat = "ddd dd MM yy";

            dateTimePicker2Upd.Format = DateTimePickerFormat.Custom;
            dateTimePicker2Upd.CustomFormat = "ddd dd MM yy";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.txtUpdName.Clear();
            this.txtUpdSurname.Clear();
            this.txtUpdPass.Clear();
            this.comboUpdN.SelectedIndex = -1;
            this.comboUpdDept.SelectedIndex = -1;
            this.dateTimePicker1Upd.Value = DateTimePicker.MinimumDateTime;
            this.dateTimePicker2Upd.Value = DateTimePicker.MinimumDateTime;
            this.errorProvider.Clear();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            _ParentForm.mainform_refresh(sender, e);

            //mainForm f1 = new mainForm();
            //f1.Show();

            this.Close();

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (areFieldsValidated())
            {
                var doc = XDocument.Load(@"C:\Project XML Files\records.xml");
                string selectedID = ""; //string name; string surname;

                //name = this.txtUpdName.Text;
                // surname = this.txtUpdSurname.Text.ToString();
                selectedID = this.lblUpdID.Text;

                var items = from item in doc.Descendants("student")
                            where item.Element("id").Value == selectedID
                            select item;
                //MessageBox.Show()

                foreach (XElement itemElement in items)
                {
                    DateTime DOB = this.dateTimePicker1Upd.Value;
                    DateTime DOR = this.dateTimePicker2Upd.Value;
                    string gender = "";
                    //MessageBox.Show("Heelo");
                    //MessageBox.Show(itemElement.Value.ToString());
                    itemElement.SetElementValue("name", this.txtUpdName.Text);
                    itemElement.SetElementValue("surname", this.txtUpdSurname.Text);
                    if (this.radioMale.Checked)
                        gender = radioMale.Text;
                    else if (this.radioFemale.Checked)
                        gender = radioFemale.Text;
                    itemElement.SetElementValue("gender", gender);
                    itemElement.SetElementValue("nationality", this.comboUpdN.Text);
                    itemElement.SetElementValue("passNo", this.txtUpdPass.Text);
                    itemElement.SetElementValue("DOB", DOB.ToShortDateString());
                    itemElement.SetElementValue("department", this.comboUpdDept.Text);
                    itemElement.SetElementValue("DOR", DOR.ToShortDateString());

                    //itemElement.SetElementValue("name", name);
                    //itemElement.SetElementValue("surname", surname);

                    //itemElement.SetElementValue("age", comboUpdateAge.SelectedItem.ToString());
                }

                doc.Save(@"C:\Project XML Files\records.xml");

                MessageBox.Show("You have sucessfully updated the XML ");
            }
        }

        private bool areFieldsValidated()
        {
            bool isValidated = true;

            if (txtUpdName.Text.Length < 1)
            {
                errorProvider.SetError(txtUpdName, "Please fill in the name");
                isValidated = false;
            }

            else if (txtUpdSurname.Text.Length < 1)
            {
                errorProvider.SetError(txtUpdSurname, "Please fill in the surname");
                isValidated = false;
            }

            else if (txtUpdPass.Text.Length < 1)
            {
                errorProvider.SetError(txtUpdPass, "Please fill in the passport number");
                isValidated = false;
            }

            else if (comboUpdDept.Text.Length < 1)
            {
                errorProvider.SetError(comboUpdDept, "Please select a department");
                isValidated = false;
            }

            else if (comboUpdN.SelectedIndex == -1)
            {
                errorProvider.SetError(comboUpdN, "Please select a department");
                isValidated = false;
            }

            else if (dateTimePicker1Upd.Value == DateTimePicker.MinimumDateTime)
            {
                errorProvider.SetError(dateTimePicker1Upd, "Please select a date");
                isValidated = false;
            }

            else if (dateTimePicker2Upd.Value == DateTimePicker.MinimumDateTime)
            {
                errorProvider.SetError(dateTimePicker2Upd, "Please select a date");
                isValidated = false;
            }

            return isValidated;
        }
    }
}
