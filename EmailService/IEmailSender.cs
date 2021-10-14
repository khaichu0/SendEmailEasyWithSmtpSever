using System;
using System.Collections.Generic;
using System.Text;

namespace EmailService
{
    public interface IEmailSender
    {
        void sendEmail(Message message);
    }
}
