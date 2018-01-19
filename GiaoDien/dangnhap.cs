using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
namespace GiaoDien
{
    public partial class dangnhap : Form
    {
        public dangnhap()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lb_project_Click(object sender, EventArgs e)
        {

        }

        private void btn_signin_Click(object sender, EventArgs e)
        {
            String constr = ConfigurationManager.ConnectionStrings["QLHT"].ConnectionString;
            SqlConnection con = new SqlConnection(constr);
            String query = "select * from admin";
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader reader = cmd.ExecuteReader();
            admin ad = new admin();
            if (reader.Read())
            {
                
                ad.user = reader["tendangnhap"].ToString();
                ad.passs = reader["matkhau"].ToString();
                if (txt_username.Text == ad.user && txt_password.Text == ad.passs)
                {
                    MessageBox.Show("Đăng nhập thành công!");
                    hethong ht = new hethong();
                    ht.Show();
                    this.Visible = false;
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập lại!");
                }
            }
            
        }

        private void dangnhap_Load(object sender, EventArgs e)
        {
            
        }
    }
}
