using SpyGame.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpyGame.Services
{
    public class EncodeMessageService : IEncodeMessage
    {
        public string Encoding(string message)
        {
            // Define the digits to be used for "Jump the Five"
             char[] numberMapping = { '0', '2', '3', '4', '5', '5', '7', '8', '9', '0' };

            // Create a StringBuilder to build the encoded message
            StringBuilder encodedMessage = new StringBuilder();

            foreach (char c in message)
            {
                // check if
                if (char.IsDigit(c))
                {
                    // If the character is a digit, apply the mapping
                    int digit = c - '0';
                    encodedMessage.Append(numberMapping[digit]);
                }
                else
                {
                    // If not a digit, append the character as is
                    encodedMessage.Append(c);
                }
            }

            return encodedMessage.ToString();
        }
    }
}
