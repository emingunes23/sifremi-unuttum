using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;


namespace SifremiUnuttum
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Mail_Göndermek mg = new Mail_Göndermek();
            this.Hide();
            mg.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-4AKRVU5\\SQLEXPRESS12;Initial Catalog=\"Şifremi Unuttum\";Integrated Security=True");
            SqlDataAdapter sda = new SqlDataAdapter("select * from sifremiUnuttum where kullanıcıadı='"+txtUser.Text+"' and sifre='" + txtPass + "' ", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if(dt.Rows.Count> 0)
            {
                MessageBox.Show("Giriş Başarılı");
            }
            else
            {
                MessageBox.Show("Error");
            }
        }
    }
}
