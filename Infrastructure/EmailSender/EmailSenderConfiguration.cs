﻿namespace Graft.Infrastructure
{
    public class EmailSenderConfiguration
    {
        public string Server { get; set; }
        public string UserName { get; set; }
        public int Port { get; set; }
        public string Password { get; set; }
        public string Address { get; set; }
        public string DisplayName { get; set; }
    }
}
