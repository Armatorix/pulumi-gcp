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
    public sealed class InstanceNetworkInterfaceAccessConfig
    {
        /// <summary>
        /// The IP address that will be 1:1 mapped to the instance's
        /// network ip. If not given, one will be generated.
        /// </summary>
        public readonly string? NatIp;
        /// <summary>
        /// The [networking tier][network-tier] used for configuring this instance.
        /// This field can take the following values: PREMIUM or STANDARD. If this field is
        /// not specified, it is assumed to be PREMIUM.
        /// </summary>
        public readonly string? NetworkTier;
        /// <summary>
        /// The DNS domain name for the public PTR record.
        /// To set this field on an instance, you must be verified as the owner of the domain.
        /// See [the docs](https://cloud.google.com/compute/docs/instances/create-ptr-record) for how
        /// to become verified as a domain owner.
        /// </summary>
        public readonly string? PublicPtrDomainName;

        [OutputConstructor]
        private InstanceNetworkInterfaceAccessConfig(
            string? natIp,

            string? networkTier,

            string? publicPtrDomainName)
        {
            NatIp = natIp;
            NetworkTier = networkTier;
            PublicPtrDomainName = publicPtrDomainName;
        }
    }
}
