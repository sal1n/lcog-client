using System;

namespace LcogClient.Model
{
    /// <summary>
    /// Represents a message.
    /// </summary>
    public class Message
    {
        #region Properties
        /// <summary>
        /// Message type.
        /// </summary>
        public string Type { get; set; }
        /// <summary>
        /// Sender.
        /// </summary>
        public string From { get; set; }
        /// <summary>
        /// Message body.
        /// </summary>
        public string Body { get; set; }

        #endregion

        #region Constructors
        /// <summary>
        /// Default constructor.
        /// </summary>
        public Message()
        {
        }
        #endregion
    }
}
