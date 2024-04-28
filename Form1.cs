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

namespace WindowsFormsAppcrud1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-BMLIOU8H\SQLEXPRESS;Initial Catalog=student2;Integrated Security=True");
        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string show = "select * from crud";
                SqlDataAdapter sda = new SqlDataAdapter(show, con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("error" + ex);
            }
            finally
            {
                con.Close();
            }
            try
            {
                con.Open();
                DataSet ds = new DataSet();
                string u_name = "select * from crud";
                SqlDataAdapter sda = new SqlDataAdapter(u_name, con);
                sda.Fill(ds);
                comboBox1.DataSource = ds.Tables[0];
                comboBox1.DisplayMember = ds.Tables[0].Columns[0].ToString();
                con.Close();

            }
            catch(Exception ex)
            {
                MessageBox.Show("ivalid" + ex);
            }
            finally
            {
                con.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string querry = "insert into crud(name,age,phone)values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "')";
                SqlDataAdapter sda = new SqlDataAdapter(querry, con);
                DataTable dt = new DataTable();
                sda.SelectCommand.ExecuteNonQuery();
                MessageBox.Show("success");
            }
            catch (Exception ex)
            {
                MessageBox.Show("error" + ex);
            }
            finally
            {
                con.Close();
            }
            try
            {
                con.Open();
                string show = "select * from crud";
                SqlDataAdapter sda = new SqlDataAdapter(show, con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("error" + ex);
            }
            finally
            {
                con.Close();
            }
        }

        private void button2_show_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string show = "select * from crud";
                SqlDataAdapter sda = new SqlDataAdapter(show, con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("error" + ex);
            }
            finally
            {
                con.Close();
            }
        }

        private void button2_search_Click(object sender, EventArgs e)
        {
            string s_name = comboBox1.Text;
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("Select * from [crud] where (name='" + s_name + "')", con);
                SqlDataReader ab;
                ab = cmd.ExecuteReader();
                while (ab.Read())
                {
                    textBox1.Text = ab.GetValue(0).ToString();
                    textBox2.Text = ab.GetValue(1).ToString();
                    textBox3.Text = ab.GetValue(2).ToString();
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show("not found" + ex);
            }
            finally
            {
                con.Close();
            }


        }

        private void button3_update_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string querry = "update crud set age='" + textBox2.Text + "',phone='" + textBox3.Text + "' where name='" + textBox1.Text + "'";
                SqlDataAdapter sda = new SqlDataAdapter(querry, con);
                sda.SelectCommand.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("update successfully");
            }
            catch(Exception ex)
            {
                MessageBox.Show("error" + ex);
            }
            finally
            {
                con.Close();
            }
            try
            {
                con.Open();
                string show = "select * from crud";
                SqlDataAdapter sda = new SqlDataAdapter(show, con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("error" + ex);
            }
            finally
            {
                con.Close();
            }
        }

        private void button2_delete_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand dlt = new SqlCommand("delete from crud where name='" + comboBox1.Text + "'",con);
                dlt.ExecuteNonQuery();
                MessageBox.Show("successfully deleted");
                con.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("error" + ex);
            }
            finally
            {
                con.Close();
            }
            try
            {
                con.Open();
                string show = "select * from crud";
                SqlDataAdapter sda = new SqlDataAdapter(show, con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("error" + ex);
            }
            finally
            {
                con.Close();
            }
            try
            {
                con.Open();
                string show = "select * from crud";
                SqlDataAdapter sda = new SqlDataAdapter(show, con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("error" + ex);
            }
            finally
            {
                con.Close();
            }
        }
    }
}
