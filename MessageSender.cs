using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JakobsOpgave
{
    public abstract class MessageSender
    {
        public abstract void SendMessage(Message message, bool isHTML);

        protected string ConvertBodyToHTML(string plainText)
        {
            return "<html><body>" + plainText + "</body></html>";
        }
    }
}
