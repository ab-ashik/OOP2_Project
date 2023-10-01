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
using System.Web;
using System.Configuration;
using System.Net;
using System.Net.Mail;
using static WindowsFormsApp1.DatabaseConnection;

namespace WindowsFormsApp1
{
    public partial class Form5 : Form
    {
        //Random rnd = new Random();
        public int otp;

        public Form5()
        {
            InitializeComponent();
        }


        private void mail(string email)
        {

            try
            {
                MailMessage msg = new MailMessage();
                msg.From = new MailAddress("abdullah74332@gmail.com");
                msg.To.Add(txtForgetPasswordEmail.Text);
                msg.Subject = "Your Recovery OTP ";
                Random rand = new Random();
                otp = rand.Next(1000, 9999);
                // msg.Body = otp.ToString();
                msg.Body = "Write this given code on text box\n" + otp.ToString() + "\nThank you!";

                SmtpClient smt = new SmtpClient();
                smt.Host = "smtp.gmail.com";
                System.Net.NetworkCredential ntcd = new NetworkCredential();
                ntcd.UserName = "abdullah74332@gmail.com";
                ntcd.Password = "abd.74332.";
                smt.Credentials = ntcd;
                smt.EnableSsl = true;
                smt.Port = 587;
                smt.Send(msg);

                MessageBox.Show("Your Mail is sended");

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            mail(txtForgetPasswordEmail.Text);
            // string query = "select EmailID from LoginDB";
            //  string query = "Select EmailID from LoginDB where EmailID='" + txtForgetPasswordEmail.Text.Trim() + "'";
            //  OleDbCommand cmd = new OleDbCommand(query, con);
            // DataTable dt = new DataTable();
            // con.Open();
            //  OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            //  da.Fill(dt)


            //  SqlDataAdapter sda = new SqlDataAdapter(query, con);
            // DataTable dtbl = new DataTable();
            // sda.Fill(dtbl);
            //  con.Close();
            //  string txtboxEmail = txtForgetPasswordEmail.Text;
            /*foreach (DataRow dr in dtbl.Rows)
            {
                foreach (DataColumn dc in dtbl.Columns)
                {
                    if (txtboxEmail == dr[dc].ToString())
                    {
                       // lblNextStep1.Visible = true;
                       // imgNextStep1.Visible = true;

                        //txtForgrtPassswordCode.Enabled = true;
                      //  btnForgetPassordNextStep.Enabled = true;
                      //  btnForgetPassordSendAgain.Enabled = true;
                      //  btnForgetPasswordSendMail.Enabled = false;

                        mail();

                        Form6 f6 = new Form6();
                        f6.Show();
                        this.Hide();
                    }*/


            //     if(dtbl.Rows.Count == 1)
            //    {
            //        mail();

            //       Form6 f6 = new Form6();
            //       f6.Show();
            //       this.Hide();
            //   }

            //    else
            //    {
            //       MessageBox.Show("This email is not exist in the given data");

            //   }





            Form6 f6 = new Form6();
            f6.Show();
            this.Hide();


        }

        /*string query = "Select * from LoginDB where EmailID='" + txtemail.Text.Trim() + "' and Password = '" + txtpass.Text.Trim() + "'";
        SqlDataAdapter sda = new SqlDataAdapter(query, sqlCon);
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
        }*/
        //}

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtForgetPasswordEmail_Leave(object sender, EventArgs e)
        {
            string query = " select EmailID from LoginDB where EmailID= '" + txtForgetPasswordEmail.Text.Trim() + "'";

            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            if (dt.Rows.Count == 1)
            {

                errorProvider1.Clear();
                button1.Enabled = true;
            }
            else
            {
                button1.Enabled = false;
                // MessageBox.Show("Email Address does not exist");
                txtForgetPasswordEmail.Focus();
                errorProvider1.SetError(this.txtForgetPasswordEmail, "Email Address does not exist");
            }
        }
    }
}
