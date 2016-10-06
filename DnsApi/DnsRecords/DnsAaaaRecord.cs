﻿using System.Net;

namespace DnsApi.DnsRecords
{
    public class DnsAaaaRecord : DnsRecordBase
    {
        public DnsAaaaRecord(IPAddress iPv6Address)
        {
            IPv6Address = iPv6Address;
        }

        // ReSharper disable once InconsistentNaming
        public IPAddress IPv6Address { get; private set; }

        public override string ToString()
        {
            return IPv6Address.ToString();
        }
    }
}
