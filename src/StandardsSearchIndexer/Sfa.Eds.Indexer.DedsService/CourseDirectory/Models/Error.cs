﻿// Code generated by Microsoft (R) AutoRest Code Generator 0.9.7.0
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Sfa.Infrastructure.Models
{
    using System;

    using Newtonsoft.Json.Linq;

    public class Error
    {
        /// <summary>
        ///     Initializes a new instance of the Error class.
        /// </summary>
        public Error()
        {
        }

        /// <summary>
        ///     Initializes a new instance of the Error class with required
        ///     arguments.
        /// </summary>
        public Error(int code, string message)
            : this()
        {
            if (message == null)
            {
                throw new ArgumentNullException("message");
            }
            Code = code;
            Message = message;
        }

        /// <summary>
        ///     Required.
        /// </summary>
        public int Code { get; set; }

        /// <summary>
        ///     Required.
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        ///     Deserialize the object
        /// </summary>
        public virtual void DeserializeJson(JToken inputObject)
        {
            if (inputObject != null && inputObject.Type != JTokenType.Null)
            {
                var codeValue = inputObject["code"];
                if (codeValue != null && codeValue.Type != JTokenType.Null)
                {
                    Code = (int)codeValue;
                }
                var messageValue = inputObject["message"];
                if (messageValue != null && messageValue.Type != JTokenType.Null)
                {
                    Message = (string)messageValue;
                }
            }
        }
    }
}