﻿using Biscuits.Redis.Resp;
using System.IO;
using System.Threading.Tasks;

namespace Biscuits.Redis.Commands.Lists
{
    internal sealed class LPop : BulkStringValueCommand
    {
        private readonly byte[] _key;

        public LPop(Stream stream, byte[] key)
            : base(stream, "LPOP")
        {
            _key = key;
        }

        protected override void WriteParameters(IRespWriter writer)
        {
            writer.WriteBulkString(_key);
        }

        protected override async Task WriteParametersAsync(IAsyncRespWriter writer)
        {
            await writer.WriteBulkStringAsync(_key);
        }
    }
}
