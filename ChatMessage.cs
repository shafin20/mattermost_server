using System;
using System.Collections.Generic;

namespace MattermostConnection
{
    public class Attachment
    {
        public string FileName { get; set; }
        public byte[] Data { get; set; }

        public Attachment(string fileName, byte[] data)
        {
            FileName = fileName;
            Data = data;
        }
    }

    public class ChatMessage
    {
        public string Sender { get; set; }
        public string Content { get; set; }
        public DateTime Timestamp { get; set; }
        public List<Attachment> Attachments { get; set; }

        public ChatMessage(string sender, string content, List<Attachment> attachments = null)
        {
            Sender = sender;
            Content = content;
            Timestamp = DateTime.Now;
            Attachments = attachments ?? new List<Attachment>();
        }

        public override string ToString()
        {
            string result = $"{Sender} - {Timestamp}\n{Content}\n";

            if (Attachments.Count > 0)
            {
                result += "Attachments:\n";
                foreach (var attachment in Attachments)
                {
                    result += $"- {attachment.FileName}\n";
                }
            }

            return result;
        }
    }
public class GenerateChatMessage {
  public ChatMessage[] CreateChatMessage()
  {
            ChatMessage[] messages = new ChatMessage[]
            {
                new ChatMessage("Janet", "Hey Chris, check out this cute cat picture!",
                    new List<Attachment>
                    {
                        new Attachment("cat.jpg", new byte[] { 0x1A, 0x2B, 0x3C, 0x4D })
                    }),
                new ChatMessage("Janet", "Hey Chris, check out this text file I just sent you!",
                    new List<Attachment>
                    {
                        new Attachment("scam.txt", new byte[] { 0x1A, 0x2B, 0x3C, 0x4D })
                    }),
                new ChatMessage("Chris", "Aww, that's adorable! Thanks for sharing."),
                new ChatMessage("Janet", "You're welcome! 😊"),
                new ChatMessage("Chris", "By the way, I found this interesting article.",
                    new List<Attachment>
                    {
                        new Attachment("article.pdf", new byte[] { 0xAA, 0xBB, 0xCC, 0xDD })
                    }),
                new ChatMessage("Janet", "Great! I'll check it out later.")
            };

            return messages;
        }
}
}