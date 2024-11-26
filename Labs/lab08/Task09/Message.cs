using System;

namespace UserMessageApp.Models
{
    [Serializable]
    public class Message
    {
        public string Recipient { get; set; }
        public string Theme { get; set; }
        public string Text { get; set; }

        public Message(string recipient, string theme, string text)
        {
            Recipient = recipient;
            Theme = theme;
            Text = text;
        }
    }
}
