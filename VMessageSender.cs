using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JakobsOpgave
{
    public class VMessageSender : MessageSender
    {
        public override void SendMessage(Message message, bool isHTML)
        {
            if (isHTML)
            {
                message.Body = ConvertBodyToHTML(message.Body);
            }
            Console.WriteLine($"VMessage sent to {message.To} with subject: \"{message.Subject}\" and body: \"{message.Body}\"");
        }
    }
}
