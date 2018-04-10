using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace LoginScreen
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string str = @"לורה'\'SQLEXPRESS";
            Console.WriteLine("str");
            SqlConnection con = new SqlConnection("Data Source = לורה'\'SQLEXPRESS; Initial Catalog = Project; Integrated Security = True");
            SqlDataAdapter sda = new SqlDataAdapter("Select count(*) from Logintable where UserName='" + textBox1.Text + "' and Pass='" + textBox2.Text + "'    ",con );
            DataTable dt = new System.Data.DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count == 1)
            {
                
            }
            else
            {

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {


        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
