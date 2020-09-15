using System;
using System.Collections.Generic;

namespace StringManipulationSMS
{
    public class StringTransformationUtil
    {
        private char SpaceCharacter = " "[0];

        public List<Message> TransformInputIntoTextMessages(string inputText)
        {   
            List<Message> messageGroup = new List<Message>();
            TextMessage textMessage = new TextMessage();

            char? currentCharacter = null;
            char? previousCharacter = null;

            int LastSpaceCharacterPosition = 0;
            int CharactersToBackTrack = 0;

            for(int i = 0; i <= (inputText.Length); i++)
            {
                if ( i == 0 )
                {
                    currentCharacter = inputText[i];
                    previousCharacter = inputText[i];
                }
                else if ( IsLastCharacter(i, inputText) )
                {
                    currentCharacter = null;
                    previousCharacter = inputText[i - 1];
                    textMessage.AppendCharacter(previousCharacter);
                }
                else
                {
                    currentCharacter = inputText[i];
                    previousCharacter = inputText[i - 1];
                    textMessage.AppendCharacter(previousCharacter);
                }

                if(previousCharacter == SpaceCharacter)
                {
                    LastSpaceCharacterPosition = textMessage.GetMessageLength();
                }

                if ( textMessage.MessageText != null )
                {
                    if ( textMessage.IsMaxLengthReached() && IsCompleteFinalWord(currentCharacter) )
                    {
                        AddMessage(messageGroup, textMessage);
                        textMessage = new TextMessage();   
                    }
                    else if ( textMessage.IsMaxLengthReached() && !IsCompleteFinalWord(currentCharacter) )
                    {
                        textMessage.TruncateMessageToLastWord(LastSpaceCharacterPosition);
                        CharactersToBackTrack = textMessage.ProvideCharactersRemaining();
                        i = ResetIndex(i, CharactersToBackTrack);

                        AddMessage(messageGroup, textMessage);
                        textMessage = new TextMessage();                         
                    }
                    else if ( IsLastCharacter(i, inputText) )
                    {
                        AddMessage(messageGroup, textMessage);
                    }
                    else
                    {
                        
                    }
                }
            }
            return messageGroup;
        }

        private bool IsCompleteFinalWord(char? characterInput)
        {
            if(characterInput == SpaceCharacter)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool IsLastCharacter(int i, string textInput)
        {
            if ( i == textInput.Length )
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private int ResetIndex(int currentPosition, int numberOfCharacters)
        {
            if ( numberOfCharacters != 0 && currentPosition != 0 )
            {
                return currentPosition - numberOfCharacters;
            }
            else
            {
                return currentPosition;
            }
        }

        public void AddMessage(List<Message> messageGroup, Message message)
        {
            if ( message != null )
                messageGroup.Add(message);
        }
    }
}