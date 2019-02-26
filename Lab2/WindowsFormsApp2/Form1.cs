using System;
using System.Collections.Generic;
using System.IO;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Runtime.Serialization.Json;
using System.ComponentModel.DataAnnotations;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public List<Student> students = new List<Student>();

        private void button1_Click(object sender, EventArgs e)
        {
            var student = new Student(new Adress());
            var regex_1 = new Regex(@"^[A-Z][a-z]{1,20}$");

            if (!regex_1.IsMatch(textBox1.Text))
                throw new Exception("Error data");
            else
                student.FirstName = textBox1.Text;

            if (!regex_1.IsMatch(textBox1.Text))
                throw new Exception("Error data");
            else
                student.SecondName = textBox2.Text;

            if (!regex_1.IsMatch(textBox1.Text))
                throw new Exception("Error data");
            else
                student.Otchestvo = textBox3.Text;

            Regex regex_2 = new Regex("[0-9]{2}");
            if (!regex_1.IsMatch(textBox1.Text))
                throw new Exception("Error data");
            else
                student.Age = (int)numericUpDown1.Value;

            student.Specialization = comboBox1.Text;
            student.Groop = (int)numericUpDown2.Value;
            student.Course = trackBar1.Value;
            student.Birthday = dateTimePicker1.Text;

            if (radioButton1.Checked)
                student.Gender = "Male";
            else if (radioButton2.Checked)
                student.Gender = "Female";
            else
                throw new ArgumentException("Введите пол");

            if (!regex_1.IsMatch(textBox1.Text))
                throw new Exception("Error data");
            else
                student.Address.City = textBox4.Text;

            student.Address.House = (int)numericUpDown4.Value;
            student.Address.Flat = (int)numericUpDown3.Value;

            if (!regex_1.IsMatch(textBox1.Text))
                throw new Exception("Error data");
            else
                student.Address.Street = textBox5.Text;

            

            students.Add(student);

            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            numericUpDown1.Value = 1;
            numericUpDown2.Value = 1;
            numericUpDown3.Value = 1;
            numericUpDown4.Value = 1;
            comboBox1.Text = "";
            trackBar1.Value = 1;
            radioButton1.Checked = false;
            radioButton2.Checked = false;

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < students.Count(); i++)
            {
                outputTextBox.Text = outputTextBox.Text +
                    "--------------------" + "\n" +
                    "Firstname: " + students.ElementAt(i).FirstName + "\r\n" +
                    "Lastname: " + students.ElementAt(i).SecondName + "\r\n" +
                    "Otchestvo: " + students.ElementAt(i).Otchestvo + "\r\n" +
                    "Age: " + students.ElementAt(i).Age + "\r\n" +
                    "Birthday: " + students.ElementAt(i).Birthday + "\r\n" +
                    "Specialization: " + students.ElementAt(i).Specialization + "\r\n" +
                    "Groop: " + students.ElementAt(i).Groop + "\r\n" +
                    "Course: " + students.ElementAt(i).Course + "\r\n" +
                    "Gender: " + students.ElementAt(i).Gender + "\r\n" +
                    "City: " + students.ElementAt(i).Address.City + "\r\n" +
                    "Street: " + students.ElementAt(i).Address.Street + "\r\n" +
                    "House: " + students.ElementAt(i).Address.House + "\r\n" +
                    "Flat: " + students.ElementAt(i).Address.Flat + "\r\n";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DataContractJsonSerializer jsonFormatter = new DataContractJsonSerializer(typeof(List<Student>));

            using (FileStream fs = new FileStream("students.json", FileMode.OpenOrCreate))
            {
                jsonFormatter.WriteObject(fs, students);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var json = new FileStream("C:/Users/Andrew/source/repos/WindowsFormsApp2/WindowsFormsApp2/bin/Debug/students.json", FileMode.Open); //создаем файловый поток
            var reader = new StreamReader(json);
            if (json.Length != 0)
            {
                var FILE = reader.ReadToEnd();
                reader.Close();
                students = JsonConvert.DeserializeObject<List<Student>>(FILE);
                for (var i = 0; i < students.Count(); i++)
                {
                    outputTextBox.Text = outputTextBox.Text +
                    "--------------------" + "\r\n" +
                    "Firstname: " + students.ElementAt(i).FirstName + "\r\n" +
                    "Lastname: " + students.ElementAt(i).SecondName + "\r\n" +
                    "\nOtchestvo: " + students.ElementAt(i).Otchestvo + "\r\n" +
                    "\nAge: " + students.ElementAt(i).Age + "\r\n" +
                    "\nBirthday: " + students.ElementAt(i).Birthday + "\r\n" +
                    "\nSpecialization: " + students.ElementAt(i).Specialization + "\r\n" +
                    "\nGroop: " + students.ElementAt(i).Groop + "\r\n" +
                    "\nCourse: " + students.ElementAt(i).Course + "\r\n" +
                    "\nGender: " + students.ElementAt(i).Gender + "\r\n" +
                    "\nCity: " + students.ElementAt(i).Address.City + "\r\n" +
                    "\nStreet: " + students.ElementAt(i).Address.Street + "\r\n" +
                    "\nHouse: " + students.ElementAt(i).Address.House + "\r\n" +
                    "\nFlat: " + students.ElementAt(i).Address.Flat + "\r\n";
                }
            }
            else
                throw new Exception("JSON файл отсутствует или пуст.");
        }

        private void outputTextBox_TextChanged(object sender, EventArgs e)
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
