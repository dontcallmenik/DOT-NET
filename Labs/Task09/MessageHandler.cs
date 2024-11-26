using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using UserMessageApp.Models;

public class MessageHandler
{
    public static void SaveMessage(Message message)
    {
        using (FileStream fs = new FileStream("messages.dat", FileMode.Append))
        {
            IFormatter formatter = new BinaryFormatter();
            formatter.Serialize(fs, message);
        }
    }

    public static List<Message> LoadMessages()
    {
        List<Message> messages = new List<Message>();
        if (File.Exists("messages.dat"))
        {
            using (FileStream fs = new FileStream("messages.dat", FileMode.Open))
            {
                IFormatter formatter = new BinaryFormatter();
                while (fs.Position < fs.Length)
                {
                    Message message = (Message)formatter.Deserialize(fs);
                    messages.Add(message);
                }
            }
        }
        return messages;
    }
}
