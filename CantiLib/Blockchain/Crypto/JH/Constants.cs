//
// Copyright 2012-2013 The CryptoNote Developers
// Copyright 2014-2018 The Monero Developers
// Copyright 2018 The TurtleCoin Developers
//
// Please see the included LICENSE file for more information.

using System;

namespace Canti.Blockchain.Crypto.JH
{
    public static class Constants
    {
        public static readonly byte[] RoundConstantZero =
        {
            0x6, 0xa, 0x0, 0x9, 0xe, 0x6, 0x6, 0x7,
            0xf, 0x3, 0xb, 0xc, 0xc, 0x9, 0x0, 0x8,
            0xb, 0x2, 0xf, 0xb, 0x1, 0x3, 0x6, 0x6,
            0xe, 0xa, 0x9, 0x5, 0x7, 0xd, 0x3, 0xe,
            0x3, 0xa, 0xd, 0xe, 0xc, 0x1, 0x7, 0x5,
            0x1, 0x2, 0x7, 0x7, 0x5, 0x0, 0x9, 0x9,
            0xd, 0xa, 0x2, 0xf, 0x5, 0x9, 0x0, 0xb,
            0x0, 0x6, 0x6, 0x7, 0x3, 0x2, 0x2, 0xa,
        };

        public static readonly byte[,] S =
        {
            {9,0,4,11,13,12,3,15,1,10,2,6,7,5,8,14},
            {3,12,6,13,5,7,1,9,15,2,0,4,11,10,14,8}
        };
    }
}
