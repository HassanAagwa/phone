using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace phone
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void clear()
        {
            txt_id.Clear();
            txt_name.Clear();
            txt_phone.Clear();
        }

        private SqlConnection conn = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=MY_DATABASE;Data Source=.");
        private SqlCommand cmd;
        private SqlDataAdapter da;
        private DataTable dt = new DataTable();

        private void Btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                cmd = new SqlCommand("insert into phone_number(ID,Name,phone) Values(" + txt_id.Text + " , '" + txt_name.Text + "','" + txt_phone.Text + "')", conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show(" جدع ", "Add", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clear();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void Btn_serch_Click(object sender, EventArgs e)
        {
            try
            {
                dt.Clear();
                da = new SqlDataAdapter("select * from phone_number where id = " + txt_id.Text + "", conn);
                da.Fill(dt);
                DataRowCollection drc = dt.Rows;
                try
                {
                    txt_name.Text = drc[0]["Name"].ToString();
                    txt_phone.Text = drc[0]["Phone"].ToString();
                }
                catch (Exception)
                {
                    MessageBox.Show(" الرقم غير موجود ");
                    txt_id.Clear();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }
        }

        private void Btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                cmd = new SqlCommand("delete from phone_number where ID = " + txt_id.Text + "", conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show(" تم الحذف بنجاح ", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clear();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
    }
}