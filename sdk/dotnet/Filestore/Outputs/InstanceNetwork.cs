// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Gcp.Filestore.Outputs
{

    [OutputType]
    public sealed class InstanceNetwork
    {
        public readonly ImmutableArray<string> IpAddresses;
        public readonly ImmutableArray<string> Modes;
        public readonly string Network;
        public readonly string? ReservedIpRange;

        [OutputConstructor]
        private InstanceNetwork(
            ImmutableArray<string> ipAddresses,

            ImmutableArray<string> modes,

            string network,

            string? reservedIpRange)
        {
            IpAddresses = ipAddresses;
            Modes = modes;
            Network = network;
            ReservedIpRange = reservedIpRange;
        }
    }
}
