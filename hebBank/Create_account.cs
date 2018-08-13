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
    public partial class Create_account : Form
    {
        public string de = ",";
        public string sl = "/";
        public string tb = "    -   ";

        public Create_account()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }



        private void Create_account_Load(object sender, EventArgs e)
        {
            comboBox1.Text = "Account Description";
            
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton7.Checked)
            {
                radioButton7.Checked = true;
                comboBox1.Items.Clear();
                comboBox1.Items.Add("Time Deposit Account");
                comboBox1.Items.Add("Demand Deposit Account");
                comboBox1.Items.Add("Forward Foreign Exchange Account");
                comboBox1.Items.Add("Demand Currency Account");
                comboBox1.Items.Add("Demand Gold Account");
                comboBox1.Items.Add("Term Gold Account");
                comboBox1.Items.Add("Maximum Term Account");
            } else if (radioButton8.Checked)
            {
                radioButton8.Checked = true;
                comboBox1.Items.Clear();
                comboBox1.Items.Add("Time Deposit Account");
                comboBox1.Items.Add("Demand Deposit Account");
                comboBox1.Items.Add("Repos");
                comboBox1.Items.Add("Investment Fund");
                comboBox1.Items.Add("Stock");
                comboBox1.Items.Add("Eurobonds");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Customers cs = new Customers();
            Random rn = new Random();


            cs.name = textBox6.Text;
            cs.surname = textBox5.Text;
            cs.gender = comboBox2.Text;
            int b_day = Convert.ToInt32(numericUpDown1.Value);
            int b_month = Convert.ToInt32(numericUpDown2.Value);
            int b_year = Convert.ToInt32(numericUpDown3.Value);
            cs.b_date = Convert.ToString(b_day) + sl + Convert.ToString(b_month) + sl + Convert.ToString(b_year);
            cs.birthplace = textBox2.Text;
            if (checkBox1.Checked)
            {
                cs.mar_status = "Single";
                cs.children = "0";
            } else if (checkBox2.Checked)
            {
                cs.mar_status = "Married";
                cs.children = textBox11.Text;
            } 
            cs.job = textBox10.Text;
            if (checkBox3.Checked)
            {
                cs.nationality = "TC";
            } else if (checkBox4.Checked)
            {
                cs.nationality = textBox12.Text;
            }
            cs.ID = textBox9.Text;
            cs.phone_number = textBox1.Text;
            cs.e_mail = textBox15.Text;
            cs.country = textBox14.Text;
            cs.city = textBox3.Text;
            cs.district = textBox7.Text;
            cs.street = textBox8.Text;
            cs.no = textBox13.Text;
            cs.post_code = textBox4.Text;
            if (radioButton7.Checked)
            {
                cs.account_type = "Individual Account";
                cs.account_description = comboBox1.Text;
            } else if (radioButton8.Checked)
            {
                cs.account_type = "Corporate Account";
                cs.account_description = comboBox1.Text;
            }
            int a_day = Convert.ToInt32(numericUpDown4.Value);
            int a_month = Convert.ToInt32(numericUpDown5.Value);
            int a_year = Convert.ToInt32(numericUpDown6.Value);

            cs.a_date = Convert.ToString(a_day) + sl + Convert.ToString(a_month) + sl + Convert.ToString(a_year);

            long acc_no = rn.Next(111111111, 999999999);
            cs.account_no = Convert.ToString(acc_no);

            FileStream outfile = new FileStream("C:/Users/user/source/repos/hebBank/Customers/" +cs.ID +".txt", FileMode.Create, FileAccess.Write);
            StreamWriter st = new StreamWriter(outfile);

            if (File.Exists(cs.ID + ".txt"))
            {
                MessageBox.Show("File Allready Exists", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
            else
            {
                st.Write(cs.ID + de);
                st.Write("" + cs.account_no + de);
                st.Write("" + cs.name + de);
                st.Write("" + cs.surname + de);
                st.Write("" + cs.account_type + de);
                st.Write("" + cs.account_description + de);
                st.Write("" + cs.a_date + de);
                st.Write("" + cs.gender + de);
                st.Write("" + cs.b_date +de);
                st.Write("" + cs.birthplace + de);
                st.Write("" + cs.mar_status + de);
                st.Write("" + cs.children + de);
                st.Write("" + cs.job + de);
                st.Write("" + cs.nationality + de);
                st.Write("" + cs.phone_number + de);
                st.Write("" + cs.e_mail + de);
                st.Write("" + cs.country + de);
                st.Write("" + cs.city + de);
                st.Write("" + cs.district + de);
                st.Write("" + cs.street + de);
                st.Write("" + cs.no + de);
                st.Write("" + cs.post_code + de);
                st.WriteLine("");
                
                st.Close();
                outfile.Close();

                Form2 f2 = (Form2)Application.OpenForms["Form2"];
                f2.listBox1.Items.Add(cs.ID + tb + cs.account_no + tb + cs.name +tb + cs.surname + tb + cs.account_type + tb + cs.account_description);
                
                MessageBox.Show("Datas Saved File", "Save Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

  

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
         
        }



        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                checkBox2.Checked = false;
                checkBox2.Enabled = false;
                textBox11.ReadOnly = true;
                textBox11.BackColor = Color.Gray;
            } else if (checkBox2.Checked)
            {
                checkBox1.Checked = false;
                checkBox1.Enabled = false;
                textBox11.ReadOnly = false;
                textBox11.BackColor = Color.White;
            }
            else
            {
                checkBox2.Enabled = true;
                checkBox1.Enabled = true;
                textBox11.ReadOnly = false;
                textBox11.BackColor = Color.White;
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                checkBox4.Checked = false;
                checkBox4.Enabled = false;
                textBox12.ReadOnly = true;
                textBox12.BackColor = Color.Gray;
            }
            else if (checkBox4.Checked)
            {
                checkBox3.Checked = false;
                checkBox3.Enabled = false;
                textBox12.ReadOnly = false;
                textBox12.BackColor = Color.White;
            }
            else
            {
                checkBox4.Enabled = true;
                checkBox3.Enabled = true;
                textBox12.ReadOnly = false;
                textBox12.BackColor = Color.White;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                checkBox1.Enabled = false;
            } else
            {
                checkBox1.Enabled = true;
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked)
            {
                checkBox3.Enabled = false;
            } else
            {
                checkBox3.Enabled = true;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
