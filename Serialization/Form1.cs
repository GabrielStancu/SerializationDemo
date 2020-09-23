using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;
using Newtonsoft.Json;
using System.IO;

namespace Serialization
{
    //Serializare in 3 formate diferite: Binary, XML, JSON
    //Fiecare trimite string-ul in alt fisier
    //NU POATE DESERIALIZA DACA NU A SERIALIZAT PRIMA DATA CU UN ANUMIT FORMAT. A SERIALIZAT CU UN ANUMIT FORMAT DACA EXISTA FISIERUL CORESPUNZATOR!
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btSerialize_Click(object sender, EventArgs e) //Binar
        {
            Employee emp = new Employee();
            emp.preluare_date(txtName.Text, txtPhoneNo.Text, dtpDoB.Value, txtDepartment.Text, Int32.Parse(txtSalary.Text));

            BinaryFormatter bf = new BinaryFormatter();
            FileStream fs = new FileStream("serialized.binary", FileMode.Create, FileAccess.ReadWrite);

            try
            {
                using (fs)
                {
                    bf.Serialize(fs, emp);
                    lblStatus.Text = "Serialized";
                    golire_controale();
                }
            }
            catch 
            {
                lblStatus.Text = "Error while serializing";
            }
        }

        private void btDeserialize_Click(object sender, EventArgs e) //Binar
        {
            Employee emp = new Employee();

            BinaryFormatter bf = new BinaryFormatter();
            FileStream fs = new FileStream("serialized.binary", FileMode.Open, FileAccess.Read, FileShare.None);

            try
            {
                using (fs)
                {
                    emp = (Employee)bf.Deserialize(fs);
                    returnare_date(emp);

                    lblStatus.Text = "Deserialized";
                }
            }
            catch
            {
                lblStatus.Text = "Error while deserializing";
            }
        }

        private void btnJSerialize_Click(object sender, EventArgs e) //JSON
        {
            Employee emp = new Employee();
            emp.preluare_date(txtName.Text, txtPhoneNo.Text, dtpDoB.Value, txtDepartment.Text, Int32.Parse(txtSalary.Text));

            File.WriteAllText("JSON.txt", JsonConvert.SerializeObject(emp));

            golire_controale();
        }

        private void btnJDeserialize_Click(object sender, EventArgs e) //JSON
        {
            Employee emp = new Employee();
            emp = JsonConvert.DeserializeObject<Employee>(File.ReadAllText("JSON.txt"));

            returnare_date(emp);
        }

        private void XmlSerialize_Click(object sender, EventArgs e) //XML
        {
            Employee emp = new Employee();
            emp.preluare_date(txtName.Text, txtPhoneNo.Text, dtpDoB.Value, txtDepartment.Text, Int32.Parse(txtSalary.Text));

            XmlSerializer bf = new XmlSerializer(typeof(Employee));
            FileStream fs = new FileStream("serialized.xml", FileMode.Create, FileAccess.ReadWrite);

            try
            {
                using (fs)
                {
                    bf.Serialize(fs, emp);
                    lblStatus.Text = "Serialized";
                    golire_controale();
                }
            }
            catch
            {
                lblStatus.Text = "Error while serializing";
            }
        }

        private void XmlDeserialize_Click(object sender, EventArgs e) //XML
        {
            Employee emp = new Employee();

            XmlSerializer bf = new XmlSerializer(typeof(Employee));
            FileStream fs = new FileStream("serialized.xml", FileMode.Open, FileAccess.Read, FileShare.None);

            try
            {
                using (fs)
                {
                    emp = (Employee)bf.Deserialize(fs);
                    returnare_date(emp);
                    lblStatus.Text = "Deserialized";
                }
            }
            catch
            {
                lblStatus.Text = "Error while deserializing";
            }
        }

        private void returnare_date(Employee emp) //incarcare controale cu date 
        {
            txtName.Text = emp.Name;
            txtPhoneNo.Text = emp.Phone;
            dtpDoB.Value = emp.DoB;
            txtDepartment.Text = emp.Department;
            txtSalary.Text = emp.Salary.ToString();
        }

        private void golire_controale() //golire controale dupa preluare date 
        {
            txtName.Text = string.Empty;
            txtPhoneNo.Text = string.Empty;
            dtpDoB.Value = DateTime.Today;
            txtDepartment.Text = string.Empty;
            txtSalary.Text = string.Empty;
        }
    }
}
