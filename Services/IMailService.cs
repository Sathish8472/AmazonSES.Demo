﻿using AmazonSES.Demo.Models;

namespace AmazonSES.Demo.Services
{
    public interface IMailService
    {
        Task SendEmailAsync(MailRequest mailRequest);
    }
}
