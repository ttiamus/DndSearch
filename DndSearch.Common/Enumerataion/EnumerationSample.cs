/*using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Mail;
using System.Text;

namespace DndSearch.Common.Enumerataion
{
    public sealed class EmailType : Enumeration<EmailType, int>
    {
        public static readonly EmailType AnythingElse = new AnythingElseType();
        public static readonly EmailType SpecialEmail = new SpecialEmailType();

        protected EmailType(int value, string displayName) : base(value, displayName)
        {
        }

        protected static string SendGridSmtp
        {
            get { return "smtp.sendgrid.net"; }
        }

        protected static int SendGridPort
        {
            get { return 587; }
        }

        public abstract SmtpSettings GetSmtpSettings();

        private class AnythingElseType : EmailType
        {
            public AnythingElseType() : base(0, "AnythingElse")
            {
            }

            public override SmtpSettings GetSmtpSettings()
            {
                return new SmtpSettings
                {
                    Port = SendGridPort,
                    Server = SendGridSmtp,
                    UseSsl = true,
                    Username = "some@user.com",
                    Password = "somePassword"
                };
            }
        }

        private class SpecialEmailType : EmailType
        {
            public SpecialEmailType() : base(1, "SpecialEmail")
            {
            }

            public override SmtpSettings GetSmtpSettings()
            {
                return new SmtpSettings
                {
                    Port = SendGridPort,
                    Server = SendGridSmtp,
                    UseSsl = true,
                    Username = "another@user.com",
                    Password = "anotherPassword"
                };
            }
        }
    }
}

public class SmtpSettings
{
    public string Server { get; set; }

    public string Username { get; set; }

    public string Password { get; set; }

    public bool UseSsl { get; set; }

    public int Port { get; set; }

    public SmtpClient CreateSmtpClient()
    {
        return new SmtpClient(Server, Port)
        {
            Credentials = new NetworkCredential(Username, Password),
            EnableSsl = UseSsl,
            DeliveryMethod = SmtpDeliveryMethod.Network,
        };
    }
}*/