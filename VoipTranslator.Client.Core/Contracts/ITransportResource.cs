﻿using System;
using VoipTranslator.Protocol.Dto;

namespace VoipTranslator.Client.Core.Contracts
{
    public interface ITransportResource
    {
        void Send(string data);

        event EventHandler<PacketEventArgs> Received;
    }
}
