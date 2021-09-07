using EasyLoca.Model;
using System;
using System.Net;
using System.Net.Mail;

namespace ConsoleTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Model class testing...");

            // Test Email sending
            string targetEmailAddress = "sebastien.alvarez@yahoo.fr";
            string sourceEmailAddress = "sebastien.alvarez@yahoo.fr";
            string sourceEmailPassword = "pnvvuwgvrrpocoxb";
            string sourceSmtpServerAddress = "smtp.mail.yahoo.com";
            Console.WriteLine("Email object creation");
            Email sourceEmail = new Email(sourceEmailAddress, sourceEmailPassword, sourceSmtpServerAddress);
            Console.WriteLine("Email sending...");
            bool result = sourceEmail.SendEmail("Test envoi email automatique", $"Test envoi email automatique {DateTime.Now.ToString()}", null, targetEmailAddress);
            if (result)
            {
                Console.WriteLine("Email sent successfully !");
            }
            else
            {
                Console.WriteLine("Failure...");
            }
        }

    }
}
