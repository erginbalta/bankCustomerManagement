using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hebBank
{
    public partial class User_Screen : Form
    {
        public string[] fields;
        const char delim = ',';
        
        

        public User_Screen()
        {
            InitializeComponent();
            
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {

        }

        private void User_Screen_Load(object sender, EventArgs e)
        {
            groupBox1.Enabled = false;
            button1.Enabled = false;
            groupBox2.Enabled = false;
            button2.Enabled = false;
            groupBox3.Enabled = false;
            groupBox4.Enabled = false;
            
            Customers cs = new Customers();
            FileStream fs = new FileStream(@"C:\Users\user\source\repos\hebBank\Customers\" + Form2.search_ID + ".txt", mode: FileMode.Open, access: FileAccess.Read);
            StreamReader sr = new StreamReader(fs);

            string line = sr.ReadLine();
            while (line != null)
            {
                fields = line.Split(delim);
                cs.ID = fields[0];
                cs.account_no = fields[1];
                cs.name = fields[2];
                cs.surname = fields[3];
                cs.account_type = fields[4];
                cs.account_description = fields[5];
                cs.a_date = fields[6];
                cs.gender = fields[7];
                cs.b_date = fields[8];
                cs.birthplace = fields[9];
                cs.mar_status = fields[10];
                cs.children = fields[11];
                cs.job = fields[12];
                cs.nationality = fields[13];
                cs.phone_number =fields[14];
                cs.e_mail = fields[15];
                cs.country = fields[16];
                cs.city = fields[17];
                cs.district = fields[18];
                cs.street = fields[19];
                cs.no = fields[20];
                cs.post_code = fields[21];
                line = sr.ReadLine();
            }
            textBox1.Text = cs.name;
            textBox2.Text = cs.surname;
            textBox3.Text = Convert.ToString(cs.ID);
            textBox4.Text = cs.nationality;
            textBox5.Text = cs.mar_status;
            textBox6.Text = cs.gender;
            textBox7.Text = cs.children;
            textBox17.Text = cs.job;
            textBox8.Text = cs.phone_number;
            textBox9.Text = cs.e_mail;
            textBox10.Text = cs.country;
            textBox11.Text = cs.city;
            textBox12.Text = cs.district;
            textBox13.Text = cs.street;
            textBox14.Text = cs.no;
            textBox22.Text = Convert.ToString(cs.post_code);
            textBox15.Text = cs.account_type;
            textBox16.Text = Convert.ToString(cs.account_no);
            textBox18.Text = cs.account_description;
            textBox19.Text = cs.b_date;
            textBox20.Text = cs.birthplace;
            textBox21.Text = cs.a_date;
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
            button1.Enabled = true;
            groupBox2.Enabled = false;
            button2.Enabled = false;
        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            groupBox2.Enabled = true;
            button2.Enabled = true;
            groupBox1.Enabled = false;
            button1.Enabled = false;
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Are You Sure ?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            // delete customer datas in the file

            FileInfo fi = new FileInfo(@"C:\Users\user\source\repos\hebBank\Customers\" + Form2.search_ID + ".txt");

            fi.Delete();

            Form2 f2 = new Form2();
            f2.Refresh();

            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream(@"C:\Users\user\source\repos\hebBank\Customers\" + Form2.search_ID + ".txt", FileMode.Open, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);

            sw.Write(textBox3.Text + delim);
            sw.Write(textBox16.Text + delim);
            sw.Write(textBox1.Text + delim);
            sw.Write(textBox2.Text + delim);
            sw.Write(textBox15.Text + delim);
            sw.Write(textBox18.Text + delim);
            sw.Write(textBox21.Text + delim);
            sw.Write(textBox6.Text + delim);
            sw.Write(textBox19.Text + delim);
            sw.Write(textBox20.Text + delim);
            sw.Write(textBox5.Text + delim);
            sw.Write(textBox7.Text + delim);
            sw.Write(textBox17.Text + delim);
            sw.Write(textBox4.Text + delim);
            sw.Write(textBox8.Text + delim);
            sw.Write(textBox9.Text + delim);
            sw.Write(textBox10.Text + delim);
            sw.Write(textBox11.Text + delim);
            sw.Write(textBox12.Text + delim);
            sw.Write(textBox13.Text + delim);
            sw.Write(textBox14.Text + delim);
            sw.Write(textBox22.Text + delim);
            sw.WriteLine("");

            sw.Close();
            fs.Close();

            groupBox1.Enabled = false;
            button1.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream(@"C:\Users\user\source\repos\hebBank\Customers\" + Form2.search_ID + ".txt", FileMode.Open, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);

            sw.Write(textBox3.Text + delim);
            sw.Write(textBox16.Text + delim);
            sw.Write(textBox1.Text + delim);
            sw.Write(textBox2.Text + delim);
            sw.Write(textBox15.Text + delim);
            sw.Write(textBox18.Text + delim);
            sw.Write(textBox21.Text + delim);
            sw.Write(textBox6.Text + delim);
            sw.Write(textBox19.Text + delim);
            sw.Write(textBox20.Text + delim);
            sw.Write(textBox5.Text + delim);
            sw.Write(textBox7.Text + delim);
            sw.Write(textBox17.Text + delim);
            sw.Write(textBox4.Text + delim);
            sw.Write(textBox8.Text + delim);
            sw.Write(textBox9.Text + delim);
            sw.Write(textBox10.Text + delim);
            sw.Write(textBox11.Text + delim);
            sw.Write(textBox12.Text + delim);
            sw.Write(textBox13.Text + delim);
            sw.Write(textBox14.Text + delim);
            sw.Write(textBox22.Text + delim);
            sw.WriteLine("");

            sw.Close();
            fs.Close();

            groupBox2.Enabled = false;
            button2.Enabled = false;

        }
    }
}
