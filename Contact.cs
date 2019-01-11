using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Net.Mail;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Project_Mockup
{
    public partial class Contact : Form
    {
        string contacter = "";
        string contactee = "";
        string password ="";

        public Contact(string a,string b,string c)
        {
            InitializeComponent();
            contacter = a;
            password=c;
            contactee = b;
            textBox1.Text = contactee;
        }



        private void txtEmailSubject_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            //Sends emails from verified smpt host (John's school email) to another verified smtp recipient ()
            MailMessage message = new MailMessage();
            SmtpClient SmtpServer = new SmtpClient("smtp-mail.outlook.com");
            message.From = new MailAddress(contacter);
            message.To.Add(contactee);
            message.Subject = txtEmailSubject.Text;
            message.Body = txtEmail.Text;
            SmtpServer.Port = 587;
            SmtpServer.Credentials = new System.Net.NetworkCredential(contacter, password);
            SmtpServer.EnableSsl = true;
            SmtpServer.Send(message);
            this.Dispose();
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Close();
        }
    }
}
