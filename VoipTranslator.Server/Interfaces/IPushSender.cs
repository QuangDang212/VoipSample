﻿namespace VoipTranslator.Server.Interfaces
{
    public interface IPushSender
    {
        void SendVoipPush(string pushUrl, string callerNumber, string callerName);
    }
}
