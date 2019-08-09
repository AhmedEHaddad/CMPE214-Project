using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
//using Microsoft.SqlServer.Server;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace CMPE214_Project
{
    public partial class mainForm : Form
    {
        //List<Student> recordList = new List<Student>();
        bool firstTime = true;


        public mainForm()
        {
            InitializeComponent();
        }

        private void btnRead_Click(object sender, EventArgs e)
        {

            XmlDocument doc = new XmlDocument();
            doc.Load(@"c:\Project XML Files\records.xml");
            foreach (XmlNode node in doc.SelectNodes("//student"))
            {
                ListViewItem row = new ListViewItem(node.SelectSingleNode("id").InnerText);

                ListViewItem.ListViewSubItem itms1 = new ListViewItem.ListViewSubItem(row, node.SelectSingleNode("name").InnerText);
                ListViewItem.ListViewSubItem itms2 = new ListViewItem.ListViewSubItem(row, node.SelectSingleNode("surname").InnerText);

                row.SubItems.Add(itms1);
                row.SubItems.Add(itms2);

                listView1.Items.Add(row);

            }
            EnableComponents2();

        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            string foldername = @"c:\Project XML Files";
            if (!System.IO.Directory.Exists(foldername))
            {
               Directory.CreateDirectory(foldername);
            }


            string path = Path.Combine(foldername, "login.xml");
            if (!System.IO.File.Exists(path))
                    File.Create(path);

            path = Path.Combine(foldername, "records.xml");
            if (!System.IO.File.Exists(path))
                    File.Create(path);

            //
            if (firstTime)
                gridStuff();
            //
            /*listView1.View = View.Details;
            listView1.GridLines = true;
            listView1.FullRowSelect = true;

            listView1.Columns.Add("Id", 100, HorizontalAlignment.Center);
            listView1.Columns.Add("Name", 200, HorizontalAlignment.Center);
            listView1.Columns.Add("Surname", 300, HorizontalAlignment.Center);*/
            //listView1.Columns.Add("Department", 800, HorizontalAlignment.Center);
            //
            
            disableComponents();

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbl_ID.Text = listView1.FocusedItem.SubItems[0].Text;
            lbl_name.Text = listView1.FocusedItem.SubItems[1].Text;
            lbl_surname.Text = listView1.FocusedItem.SubItems[2].Text;

            var doc = XDocument.Load(@"C:\Project XML Files\records.xml");
            string selectedID = ""; //string name; string surname;
            selectedID = this.lbl_ID.Text;

            var items = from item in doc.Descendants("student")
                        where item.Element("id").Value == selectedID
                        select item;
            foreach (XElement itemElement in items)
            {

                
                this.lbl_nationality.Text = itemElement.Element("nationality").Value;
                this.lbl_pass.Text = itemElement.Element("passNo").Value;
                this.lbl_DOB.Text = itemElement.Element("DOB").Value;
                this.lbl_dep.Text = itemElement.Element("department").Value;
                this.lbl_DOR.Text = itemElement.Element("DOR").Value;
                this.lblGender.Text = itemElement.Element("gender").Value;
                //this.pictureBox1.Image = listView1.FocusedItem.pic;
            }

            /*lbl_nationality.Text = listView1.FocusedItem.SubItems[3].Text;
            lbl_pass.Text = listView1.FocusedItem.SubItems[4].Text;
            lbl_DOB.Text = listView1.FocusedItem.SubItems[5].Text;
            lbl_dep.Text = listView1.FocusedItem.SubItems[6].Text;
            lbl_DOR.Text = listView1.FocusedItem.SubItems[7].Text;*/
            //pictureBox1.Image = listView1.FocusedItem.pic;

            EnableComponents();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FormAdd f1 = new FormAdd();

            f1.Show();
           // this.Hide();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            FormUpdate f2 = new FormUpdate(this);

            f2.lblUpdID.Text = this.lbl_ID.Text;
            f2.txtUpdName.Text = this.lbl_name.Text;
            f2.txtUpdSurname.Text = this.lbl_surname.Text;
            f2.comboUpdN.Text = this.lbl_nationality.Text;
            f2.txtUpdPass.Text = this.lbl_pass.Text;

            //f2.dateTimePicker1Upd.Value = this.lbl_DOB.Text;
            //f2.dateTimePicker1Upd.Value = DateTime.ParseExact(this.lbl_DOB.Text, "ddd-dd-MM-yyyy",
            //System.Globalization.CultureInfo.InvariantCulture);
            f2.dateTimePicker1Upd.Value = Convert.ToDateTime(this.lbl_DOB.Text);

            f2.comboUpdDept.Text = this.lbl_dep.Text;

            f2.dateTimePicker2Upd.Value = Convert.ToDateTime(this.lbl_DOR.Text);
            // f2.dateTimePicker2Upd = this.lbl_DOR.Text;

            if (this.lblGender.Text == "Male")
                f2.radioMale.Checked = true;
            else if (this.lblGender.Text == "Female")
                f2.radioFemale.Checked = true;

            f2.Show();
            //this.Hide();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            FormAdmin f3 = new FormAdmin();

            f3.Show();
            this.Hide();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //int selectedID = 0;
            var doc = XDocument.Load(@"c:\Project XML Files\records.xml");

            //selectedID = int.Parse(this.lbl_ID.Text.ToString());
            string selectedID = "";
            selectedID = this.lbl_ID.Text.ToString();

            if (MessageBox.Show("Do you want to delete the record that has the id: " + selectedID, "Warning",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                doc.Descendants("student")
                    .Where(x => (string)x.Element("id") == selectedID)
                    .Remove();

                MessageBox.Show("You have sucessfully deleted the person with the ID :  " + selectedID);

                doc.Save(@"c:\Project XML Files\records.xml");
                //form refresh
                listView1.Items.Clear();
                mainForm_Load(sender, e);
            }
        }

        private void disableComponents()
        {
            this.btnUpdate.Enabled = false;
            this.btnDelete.Enabled = false;

            //this.btnRead.Enabled = false;
            this.btnAdd.Enabled = false;
            this.btnAdmin.Enabled = false;

        }

        private void EnableComponents()
        {
            this.btnUpdate.Enabled = true;
            this.btnDelete.Enabled = true;
        }
        private void EnableComponents2()
        {
            this.btnRead.Enabled = true;
            this.btnAdd.Enabled = true;
            this.btnAdmin.Enabled = true;

        }

        private void btnXcreate_Click(object sender, EventArgs e)
        {
            //login.xml
            XmlDocument logindoc = new XmlDocument();
            logindoc.LoadXml("<users>" +
                "<user>" +
                "<username>" + "admin" + "</username>" +
                "<password>" + "admin" + "</password>" 
                + "</user>"
                + "</users>");

            using (XmlTextWriter writer = new XmlTextWriter(@"C:\Project XML Files\login.xml", null))
            {
                writer.Formatting = Formatting.Indented;
                logindoc.Save(writer);
                MessageBox.Show("XML login file is created/reset to its original state");
            }

            //
            EnableComponents2();

            //dummy records into records.xml
            XDocument doc = new XDocument(
            new XDeclaration("1.0", "utf-8", "yes"),
            new XComment("A sample xml file"),
            new XElement("students",
            new XElement("student",
                //new XAttribute("id", 1),
                    new XElement("id", "1"),
                    new XElement("name", "cain"),
                    new XElement("surname", "kazimoglu"),
                    new XElement("gender", "Male"),
                    new XElement("nationality", "Cypriot"),
                    new XElement("passNo", "A191"),
                    new XElement("DOB", "date"),
                    new XElement("department", "Computer Engineering"),
                    new XElement("DOR", "date")),
            new XElement("student",
                //new XAttribute("id", 2),
                    new XElement("id", "2"),
                    new XElement("name", "morty"),
                    new XElement("surname", "smith"),
                    new XElement("gender", "Male"),
                    new XElement("nationality", "American"),
                    new XElement("passNo", "A191"),
                    new XElement("DOB", "date"),
                    new XElement("department", "Computer Engineering"),
                    new XElement("DOR", "date")),
            new XElement("student",
               //new XAttribute("id", 3),
                    new XElement("id", "3"),
                    new XElement("name", "rick"),
                    new XElement("surname", "sanchez"),
                    new XElement("gender", "Male"),
                    new XElement("nationality", "English"),
                    new XElement("passNo", "A191"),
                    new XElement("DOB", "date"),
                    new XElement("department", "Computer Engineering"),
                    new XElement("DOR", "date"))
            )
            );

            doc.Save(@"C:\Project XML Files\records.xml");
            MessageBox.Show("XML records file is created/reset to its original state");

            /*XmlDocument recordsdoc = new XmlDocument();
            recordsdoc.LoadXml("<students>" +
                "<student>" +
                "<id>" + "1" + "</id>" +
                "<name>" + "cain" + "</name>" +
                "<surname>" + "kizmoglu" + "</surname>"
                + "</student>"+
                "<student>" +
                "<id>" + "2" + "</id>" +
                "<name>" + "A" + "</name>" +
                "<surname>" + "B" + "</surname>"
                + "</student>"+
                "<student>" +
                "<id>" + "3" + "</id>" +
                "<name>" + "C" + "</name>" +
                "<surname>" + "D" + "</surname>"
                + "</student>"
                + "</students>");

            using (XmlTextWriter writer = new XmlTextWriter(@"C:\Project XML Files\records.xml", null))
            {
                writer.Formatting = Formatting.Indented;
                recordsdoc.Save(writer);
                MessageBox.Show("XML records file is created/reset to its original state");
            }*/

        }
        public void mainform_refresh(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            firstTime = false;
            mainForm_Load(sender, e);

            this.lbl_ID.Text = "<ID>";
            this.lbl_name.Text = "<Name>";
            this.lbl_surname.Text = "<Surname>";
            this.lbl_nationality.Text = "<Nationality>";
            this.lbl_pass.Text = "<Passport No.>";
            this.lbl_DOB.Text = "<Date>";
            this.lbl_dep.Text = "<Department>";
            this.lbl_DOR.Text = "<Date>";
            this.lblGender.Text = "<Gender>";
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            mainform_refresh(sender, e);

        }

        private void gridStuff()
        {
            listView1.View = View.Details;
            listView1.GridLines = true;
            listView1.FullRowSelect = true;

            listView1.Columns.Add("Id", 100, HorizontalAlignment.Center);
            listView1.Columns.Add("Name", 200, HorizontalAlignment.Center);
            listView1.Columns.Add("Surname", 300, HorizontalAlignment.Center);
            //listView1.Columns.Add("Department", 800, HorizontalAlignment.Center);
        }
    }
}
