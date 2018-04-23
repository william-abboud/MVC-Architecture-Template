namespace Architecture.Data.Models
{
    using Microsoft.AspNet.Identity.Owin;
    using Microsoft.Owin;
    using System;
    using Microsoft.AspNet.Identity;
    using System.Threading.Tasks;
    using Microsoft.AspNet.Identity.EntityFramework;

    public class EmailService : IIdentityMessageService
    {
        public Task SendAsync(IdentityMessage message)
        {
            // Plug in your email service here to send an email.
            return Task.FromResult(0);
        }
    }

    public class SmsService : IIdentityMessageService
    {
        public Task SendAsync(IdentityMessage message)
        {
            // Plug in your SMS service here to send a text message.
            return Task.FromResult(0);
        }
    }
}
