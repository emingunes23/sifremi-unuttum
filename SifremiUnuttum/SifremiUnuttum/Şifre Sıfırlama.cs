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
    public partial class Şifre_Sıfırlama : Form
    {
        string username = Mail_Göndermek.to;
        public Şifre_Sıfırlama()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txtResetPass.Text == txtResetPassVer.Text)
            {
                SqlConnection con = new SqlConnection("Data Source=DESKTOP-4AKRVU5\\SQLEXPRESS12;Initial Catalog=\"Şifremi Unuttum\";Integrated Security=True");
                SqlCommand cmd = new SqlCommand("UPDATE [dbo].[sifremiUnuttum]  SET [sifre] = '"+txtResetPassVer.Text+"' WHERE username='"+username+"'", con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Sıfırlama Başarılı");
            }
            else
            {
                MessageBox.Show("yeni şifre eşleşmiyor bu yüzden aynı şifreyi girin");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 gs = new Form1();
            this.Hide();
            gs.Show();
        }
    }
}
