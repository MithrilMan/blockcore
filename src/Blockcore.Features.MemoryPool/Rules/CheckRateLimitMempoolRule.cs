﻿using Blockcore.Features.MemoryPool.Interfaces;
using Microsoft.Extensions.Logging;
using NBitcoin;

namespace Blockcore.Features.MemoryPool.Rules
{
    /// <summary>
    /// Validates the rate limit.
    /// Currently not implemented.
    /// </summary>
    public class CheckRateLimitMempoolRule : MempoolRule
    {
        public CheckRateLimitMempoolRule(Network network,
            ITxMempool mempool,
            MempoolSettings mempoolSettings,
            ChainIndexer chainIndexer,
            ILoggerFactory loggerFactory) : base(network, mempool, mempoolSettings, chainIndexer, loggerFactory)
        {
        }

        public override void CheckTransaction(MempoolValidationContext context)
        {
            // Whether to limit free transactions:
            // context.State.LimitFree
        }
    }
}