using System;

namespace JakobsOpgave
{
    public class Program
    {
        public static void Main()
        {
            // Create a new message
            Message message = new Message("to@example.com", "from@example.com", "Hello, this is a test message.", "Test Message", "cc@example.com");

            // Define the recipients
            string[] recipients = new string[] { "JasonVoorhees@murder.axe", "FreddyKrueger@murder.claw" };

            // Instantiate the MessageService class
            MessageService messageService = new MessageService();

            // Send the message via Smtp
            Console.WriteLine("Sending messages via Smtp:");
            messageService.SendMessageToAll(MessageCarrier.Smtp, recipients, message, false);

            // Send the message via VMessage
            Console.WriteLine("\nSending messages via VMessage:");
            messageService.SendMessageToAll(MessageCarrier.VMessage, recipients, message, false);
        }
    }

}