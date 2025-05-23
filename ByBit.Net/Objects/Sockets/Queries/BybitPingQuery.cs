﻿using CryptoExchange.Net;
using CryptoExchange.Net.Sockets;
using System;
using System.Collections.Generic;

namespace Bybit.Net.Objects.Sockets.Queries
{
    internal class BybitPingQuery : Query<BybitPong>
    {
        public override HashSet<string> ListenerIdentifiers { get; set; }

        public BybitPingQuery() : base(new BybitRequestMessage { RequestId = ExchangeHelpers.NextId().ToString(), Operation = "ping", Args = null }, false, 1)
        {
            RequestTimeout = TimeSpan.FromSeconds(5);
            ListenerIdentifiers = new HashSet<string>() { "pong" };
        }
    }
}
