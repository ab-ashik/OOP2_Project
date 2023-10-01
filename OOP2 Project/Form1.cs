using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static WindowsFormsApp1.DatabaseConnection;

namespace WindowsFormsApp1
{
    public partial class loginForm : Form
    {
        public static loginForm Current;
        public static string pattern = "^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$";
        public loginForm()
        {
            Current = this;
            InitializeComponent();
        }

        private void LOGIN_FORM_Load(object sender, EventArgs e)
        {

        }

        private void Submit_Click(object sender, EventArgs e)
        {
            /*if(txtemail.Text == "" || txtpass.Text == "")
            {
                MessageBox.Show("Email Address and Password field cannot be empty");
            }
            else
            {
                if (txtemail.Text == "abdullah11@gmail.com" && txtpass.Text == "mypassword")
                {
                    Form2 f2 = new Form2();
                    f2.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Wrong Username or password. Try again");
                    txtemail.Clear();
                    txtpass.Clear();
                    txtemail.Focus();
                }
            }*/

           // SqlConnection sqlCon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ABDULLAH\source\repos\DATABASES\Login_form_DB.mdf;Integrated Security=True;Connect Timeout=30");

            string query = "Select * from LoginDB where EmailID='" + txtemail.Text.Trim() + "' and Password = '" + txtpass.Text.Trim() + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);

            if (dtbl.Rows.Count == 1)
            {
                Form3 f1 = new Form3();
                this.Hide();
                f1.Show();
            }

            else
            {
                MessageBox.Show("Wrong Email or Password");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(passCheck.Checked)
            {
                txtpass.UseSystemPasswordChar = true;
            }
            else
                txtpass.UseSystemPasswordChar = false;
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
           // exitBtn.BackgroundImageLayout = ImageLayout.Stretch;
           Application.Exit();
        }

        private void txtemail_Leave(object sender, EventArgs e)
        {
            if (Regex.IsMatch(txtemail.Text, pattern) == false)
            {
                txtemail.Focus();
                errorProvider2.SetError(this.txtemail, "Invalid Email !!");
            }
            else
            {
                errorProvider2.Clear();
            }
        }

        private void txtpass_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtpass.Text) == true)
            {
                txtpass.Focus();
                errorProvider1.SetError(this.txtpass, "Empty Password are not allowed");



            }



            else
            {
                errorProvider1.Clear();
            }
        }

        private void forgotPassLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form5 f5 = new Form5();
            f5.Show();
            this.Hide();
        }
    }
}
