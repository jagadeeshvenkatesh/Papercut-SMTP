﻿namespace Papercut.Service.Infrastructure.SmtpServer
{
    using global::SmtpServer;
    using global::SmtpServer.Authentication;

    public class SimpleAuthentication : IUserAuthenticatorFactory
    {
        public IUserAuthenticator CreateInstance(ISessionContext context)
        {
            return new DelegatingUserAuthenticator((username, password) => true);
        }
    }
}