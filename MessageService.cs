using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JakobsOpgave
{
    public class MessageService
    {
        public void SendMessageToAll(MessageCarrier type, string[] to, Message message, bool isHTML)
        {
            MessageSender sender;

            if (type == MessageCarrier.Smtp)
            {
                sender = new SmtpMessageSender();
            }
            else
            {
                sender = new VMessageSender();
            }

            foreach (var recipient in to)
            {
                message.To = recipient;
                sender.SendMessage(message, isHTML);
            }
        }
    }
}
