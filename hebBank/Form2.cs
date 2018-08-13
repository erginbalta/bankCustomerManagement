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
    public partial class Form2 : Form
    {


        public static string search_ID;

        public Form2()
        {


            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Create_account cs = new Create_account();
            cs.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            char DE = ',';
            string tb = "   -   ";
            string t = "        ";
            Form1 f1 = new Form1();
            label3.Text = label3.Text +"\t" + Form1.username;

            listBox1.Items.Add(t + "ID" + t + tb + t + "Account No" + tb + "Name" + tb + "Surname" + tb + "Account type" + tb + "Account Description");

            Customers cs = new Customers();

            string[] Datas = Directory.GetFiles(@"C:\Users\user\source\repos\hebBank\Customers");
            for (int i = 0; i < Datas.Length; i++)
            {
                FileStream fs = new FileStream(Datas[i] , FileMode.Open, FileAccess.Read);
                StreamReader st = new StreamReader(fs);
                string Line = st.ReadLine();
                string[] Fields;
                while (Line != null)
                {
                    Fields = Line.Split(DE);

                    cs.ID = Fields[0];
                    cs.account_no = Fields[1];
                    cs.name = Fields[2];
                    cs.surname = Fields[3];
                    cs.account_type = Fields[4];
                    cs.account_description = Fields[5];

                    Line = st.ReadLine();
                }
                listBox1.Items.Add(cs.ID + tb + cs.account_no + tb + cs.name + tb + cs.surname + tb + cs.account_type + tb + cs.account_description);
                st.Close();
                fs.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            User_Screen us = new User_Screen();
            Customers cs = new Customers();

            search_ID = textBox1.Text;
            
            
            
            

            if (File.Exists(@"C:\Users\user\source\repos\hebBank\Customers\" +search_ID + ".txt"))
            {
                
                us.Show();
                textBox1.Text = "";
            } else if (!File.Exists(@"C:\Users\user\source\repos\hebBank\Customers\" +search_ID + ".txt"))
            {
                MessageBox.Show("File Not Found", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Text = "";
            }

        }

        private void listView1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void listBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            User_Screen us = new User_Screen();

            string x = listBox1.SelectedItem.ToString();
            string[] selectedID = x.Split(' ');

            search_ID = selectedID[0];

            if (File.Exists(@"C:\Users\user\source\repos\hebBank\Customers\" + search_ID + ".txt"))
            {

                us.Show();
            }
            else if (!File.Exists(@"C:\Users\user\source\repos\hebBank\Customers\" + search_ID + ".txt"))
            {
                MessageBox.Show("File Not Found", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
