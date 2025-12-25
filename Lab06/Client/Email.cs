using System;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;

namespace Client
{
    public partial class CLient : Form
    {
        private void btnSend_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtFrom == null || string.IsNullOrWhiteSpace(txtFrom.Text))
                {
                    MessageBox.Show("Please enter sender email address.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    if (txtFrom != null) txtFrom.Focus();
                    return;
                }

                if (txtTo == null || string.IsNullOrWhiteSpace(txtTo.Text))
                {
                    MessageBox.Show("Please enter recipient email address.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    if (txtTo != null) txtTo.Focus();
                    return;
                }

                if (txtSubject == null || string.IsNullOrWhiteSpace(txtSubject.Text))
                {
                    MessageBox.Show("Please enter email subject.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    if (txtSubject != null) txtSubject.Focus();
                    return;
                }

                if (txtBody == null || string.IsNullOrWhiteSpace(txtBody.Text))
                {
                    MessageBox.Show("Please enter email body.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    if (txtBody != null) txtBody.Focus();
                    return;
                }

                var smtpClient = new SmtpClient("smtp.gmail.com", 587);
                smtpClient.EnableSsl = true;
                smtpClient.Credentials = new NetworkCredential("huynhphuocan.ja@gmail.com", "wwri kxei hdvl veju");

                var message = new MailMessage();
                message.From = new MailAddress(txtFrom.Text);
                message.To.Add(new MailAddress(txtTo.Text));
                message.Subject = txtSubject.Text;
                message.Body = txtBody.Text;

                smtpClient.Send(message);

                MessageBox.Show("Email sent successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtFrom.Clear();
                txtTo.Clear();
                txtSubject.Clear();
                txtBody.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error sending email: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // CLient
            // 
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Name = "CLient";
            this.ResumeLayout(false);

        }
    }
}
