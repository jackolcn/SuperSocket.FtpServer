using System;
using System.Collections.Generic;
using System.Text;

namespace Raccent.Ftp.FtpService
{
    public class SystemDirectoryException : Exception
    {
        public override string Message
        {
            get
            {
                return "Can not remove or rename a system directory!";
            }
        }
    }
}
