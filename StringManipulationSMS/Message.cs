using System;

namespace StringManipulationSMS
{
    public class Message
    {
        private string _messageText;
        private int _maxMessageLength;
        public int MaxMessageLength 
        { 
            get
            { 
                return _maxMessageLength;
            }
            set 
            {
                _maxMessageLength = value;
            }
        }
        public string MessageText
        { 
            get
            {
                return _messageText;
            }
            set
            {
                _messageText = value;
            } 
        }

        public void AppendCharacter(char? character)
        {
            MessageText = _messageText + character;
        }

        public int GetMessageLength()
        {
            return _messageText.Length;
        }

        public bool IsMaxLengthReached()
        {
            if (_messageText.Length == _maxMessageLength)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void TruncateMessageToLastWord( int lastSpaceCharacterPosition )
        {
            if ( _messageText != null )
                _messageText = _messageText.Substring(0, lastSpaceCharacterPosition);
        }

        public int ProvideCharactersRemaining()
        {
            if ( _messageText != null )
            {
                return _maxMessageLength - _messageText.Length;
            }
            else
            {
                return _maxMessageLength;
            }
        }
    }
}