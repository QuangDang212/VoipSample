﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoipTranslator.Protocol.Dto
{
    public class AuthorizationRequest
    {
        public string Number { get; set; }
        public string PushUri { get; set; }
    }
}