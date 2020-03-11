﻿using System;
using System.Net;
using System.Net.Sockets;
using Blockcore.Utilities;

namespace Blockcore.Tests.Utilities
{
    public class NodeTcpListenerStub : IDisposable
    {
        private TcpListener listener;

        public NodeTcpListenerStub(IPEndPoint endpoint)
        {
            Guard.NotNull(endpoint, nameof(endpoint));

            this.listener = new TcpListener(endpoint);
            this.listener.Start();
        }

        public void Dispose()
        {
            if (this.listener != null)
            {
                this.listener.Stop();
                this.listener = null;
            }
        }
    }
}
