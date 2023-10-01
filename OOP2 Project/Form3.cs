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
using static WindowsFormsApp1.DatabaseConnection;

namespace WindowsFormsApp1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        public void disp_data()
        {

            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from crud";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into crud values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','"+textBox4.Text+"')";
            cmd.ExecuteNonQuery();
            con.Close();
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            disp_data();
            MessageBox.Show("Record inserted successfully");
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from crud";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update crud set EmployeeName='" + textBox2.Text + "',EmployeeSalary = '"+ textBox3.Text+ "',EmployeeCity = '" + textBox4.Text + "' " +
                "where EmployeeID='" + textBox1.Text + "'";
            //UPDATE Customers
            //SET ContactName = 'Alfred Schmidt', City = 'Frankfurt'
            //WHERE CustomerID = 1;
            cmd.ExecuteNonQuery();
            con.Close();
            disp_data();
            MessageBox.Show("Record updated successfully");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from crud where EmployeeID = '" + textBox1.Text + "'";
            cmd.ExecuteNonQuery();
            con.Close();
            disp_data();
            MessageBox.Show("Record deleted successfully");
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            disp_data();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                textBox1.Text = row.Cells["EmployeeID"].Value.ToString();
                textBox2.Text = row.Cells["EmployeeName"].Value.ToString();
                textBox3.Text = row.Cells["EmployeeSalary"].Value.ToString();
                textBox4.Text = row.Cells["EmployeeCity"].Value.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from crud where EmployeeID='" + textBox1.Text + "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }
    }
}
