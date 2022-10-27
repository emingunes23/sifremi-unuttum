using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;

namespace SifremiUnuttum
{
    public partial class Mail_Göndermek : Form
    {
        string randomCode;
        public static string to;
        public Mail_Göndermek()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (randomCode == (txtVerCode.Text).ToString())
            {
               to= txtEmail.Text;
                Şifre_Sıfırlama rp = new Şifre_Sıfırlama();
                this.Hide();
                rp.Show();
            }
            else
            {
                MessageBox.Show("Yanlış Giriş");
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            string from, pass, messageBody;
            Random rand = new Random();
            randomCode = (rand.Next(999999)).ToString();
            MailMessage message  = new MailMessage();
            to = (txtEmail.Text).ToString();
            from = "gunes1453gem@gmail.com";
            pass = "zchvnsprcxebaily";
            messageBody = "Resetleme Kodunuz: " + randomCode;
            message.To.Add(to);
            message.From = new MailAddress(from);
            message.Body = messageBody;
            message.Subject = "Şifre Sıfırlama Kodu";
            SmtpClient smtp = new SmtpClient("smtp.gmail.com");
            smtp.EnableSsl = true;
            smtp.Port = 587;
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.Credentials = new NetworkCredential(from,pass);
            try
            {
                smtp.Send(message);
                MessageBox.Show("kod başarıyla gönderildi");
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


            


        }

        private void txtVerCode_TextChanged(object sender, EventArgs e)
        {

        }

        private void Mail_Göndermek_Load(object sender, EventArgs e)
        {

        }
    }
}
