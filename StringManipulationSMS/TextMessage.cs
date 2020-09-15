using System;

namespace StringManipulationSMS
{
    public class TextMessage : Message
    {   
        public TextMessage()
        {
            MaxMessageLength = 140;
        }
    }
}