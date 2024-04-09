using System;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Text.Json;

namespace Student
{
    public partial class Form1 : Form
    {
        public static string fileLocation = "saved.txt";
        string destination = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, fileLocation);
        public Form1()
        {
            InitializeComponent();
        }

        private void save_Click(object sender, EventArgs e)
        {
            try
            {
                if(String.IsNullOrEmpty(id.Text) || String.IsNullOrEmpty(name_input.Text) || String.IsNullOrEmpty(department.Text) || String.IsNullOrEmpty(address.Text))
                {
                    throw new Exception("");
                }
                Student tmp = new Student(Convert.ToInt32(id.Text), name_input.Text, department.Text, address.Text, dob_input.Value);
                string json = JsonSerializer.Serialize(tmp);
                File.AppendAllText(destination, json + Environment.NewLine);
                id.Text = String.Empty;
                name_input.Text = String.Empty;
                department.Text= String.Empty;
                address.Text= String.Empty;
                DateTime now = DateTime.Now;
                dob_input.Text = now.ToString("dd-MM-yyyy");
            }catch
            {
                MessageBox.Show("You must fill all fields", "Empty not allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);              
            }
        }

        private void show_Click(object sender, EventArgs e)
        {
            StringBuilder txtBuilder = new StringBuilder();
            try
            {
                foreach (var line in File.ReadLines(destination))
                {
                    try
                    {
                        Student student = JsonSerializer.Deserialize<Student>(line);
                        txtBuilder.AppendLine($"ID: {student.ID}");
                        txtBuilder.AppendLine($"Name: {student.Name}");
                        txtBuilder.AppendLine($"Department: {student.Department}");
                        txtBuilder.AppendLine($"Address: {student.Address}");
                        txtBuilder.AppendLine($"Birth Date: {student.Dob:dd-MM-yyyy}");
                        txtBuilder.AppendLine("-----------------------------------------");
                    }
                    catch
                    {
                       
                    }
                }

                list.Text = "";
                list.AppendText(txtBuilder.ToString());
            }
            catch
            {
            }
        }
    }
}
