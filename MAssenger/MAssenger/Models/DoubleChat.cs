﻿using System;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.ComponentModel;
using System.Collections.Generic;
using MAssenger.Models;

namespace MAssenger
{
    public class DoubleChat : Conversation, IEquatable<DoubleChat>
    {
        public ICollection<Message> StarMessages = new List<Message>();
        public bool Equals(DoubleChat other)
        {
            return this.Id == other.Id;
        }
    }
}