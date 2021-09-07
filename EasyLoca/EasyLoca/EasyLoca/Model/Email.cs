/****************************************************************************************************************************************
 * 
 * Class Email
 * Author : S. ALVAREZ
 * Date : 04-09-2021
 * Status : In Progress
 * Version : 1
 * Revisions : 1 - 04-09-2021 : first version
 *  
 * Object : class that represent a parameterized email for sending email to tenants.
 * 
 ****************************************************************************************************************************************/

using System.Net;
using System.Net.Mail;

namespace EasyLoca.Model
{
    public class Email
    {
        // PROPERTIES
        /// <summary>
        /// Email adress
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// Email password
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// Email SMTP server address
        /// </summary>
        public string SmtpServerAdress { get; set; }

        /// <summary>
        /// SMTP port (587 by default)
        /// </summary>
        public int Port { get; set; }

        // CONSTRUCTORS
        /// <summary>
        /// Default constructor
        /// </summary>
        public Email()
        {
        }

        /// <summary>
        /// Creates an instance
        /// </summary>
        /// <param name="a_address">Email address</param>
        /// <param name="a_password">Email password</param>
        /// <param name="a_smtpServerAdress">Email SMTP server address</param>
        /// <param name="a_port">SMTP port (587 by default)</param>
        public Email(string a_address,
                     string a_password, 
                     string a_smtpServerAdress, 
                     int a_port = 587)
        {
            Address = a_address;
            Password = a_password;
            SmtpServerAdress = a_smtpServerAdress;
            Port = a_port;
        }

        // METHODS
        // No method...

        public bool SendEmail(string a_subject, string a_message, string a_attachmentFile, string a_targetEmailAddress)
        {
            bool isEmailSent = true;

            SmtpClient smtpClient = null;

            // Email building
            //Attachment image = new Attachment(temporaryFilePath);
            MailMessage mailMessage = new MailMessage()
            {
                From = new MailAddress(Address),
                Subject = a_subject,
                Body = a_message,
                IsBodyHtml = false
            };
            mailMessage.To.Add(a_targetEmailAddress);
            //mailMessage.Attachments.Add(image);

            smtpClient = new SmtpClient(SmtpServerAdress)
            {
                Port = Port,
                EnableSsl = true,
                Credentials = new NetworkCredential(Address, Password)
            };
            try
            {
                smtpClient.Send(mailMessage);
            }
            catch (System.Exception)
            {
                isEmailSent = false;
            }
            //image.Dispose();
            smtpClient.Dispose();
            return isEmailSent;
        }

    }
}