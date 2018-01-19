using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GiaoDien
{
    public partial class hethong : Form
    {
        public hethong()
        {
            InitializeComponent();
        }

        private void tbPThemHTr_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void tbPdangkiHT_Click(object sender, EventArgs e)
        {
            String constr = ConfigurationManager.ConnectionStrings["QLHT"].ConnectionString;
            SqlConnection con = new SqlConnection(constr);
            String query = "select * from admin";
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader reader = cmd.ExecuteReader();
        }
    }
}
