// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Gcp.Compute.Outputs
{

    [OutputType]
    public sealed class InstanceTemplateNetworkInterfaceAliasIpRange
    {
        /// <summary>
        /// The IP CIDR range represented by this alias IP range. This IP CIDR range
        /// must belong to the specified subnetwork and cannot contain IP addresses reserved by
        /// system or used by other network interfaces. At the time of writing only a
        /// netmask (e.g. /24) may be supplied, with a CIDR format resulting in an API
        /// error.
        /// </summary>
        public readonly string IpCidrRange;
        /// <summary>
        /// The subnetwork secondary range name specifying
        /// the secondary range from which to allocate the IP CIDR range for this alias IP
        /// range. If left unspecified, the primary range of the subnetwork will be used.
        /// </summary>
        public readonly string? SubnetworkRangeName;

        [OutputConstructor]
        private InstanceTemplateNetworkInterfaceAliasIpRange(
            string ipCidrRange,

            string? subnetworkRangeName)
        {
            IpCidrRange = ipCidrRange;
            SubnetworkRangeName = subnetworkRangeName;
        }
    }
}
