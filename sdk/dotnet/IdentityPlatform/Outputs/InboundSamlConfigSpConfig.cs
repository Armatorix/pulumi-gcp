// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Gcp.IdentityPlatform.Outputs
{

    [OutputType]
    public sealed class InboundSamlConfigSpConfig
    {
        public readonly string? CallbackUri;
        public readonly ImmutableArray<Outputs.InboundSamlConfigSpConfigSpCertificate> SpCertificates;
        public readonly string? SpEntityId;

        [OutputConstructor]
        private InboundSamlConfigSpConfig(
            string? callbackUri,

            ImmutableArray<Outputs.InboundSamlConfigSpConfigSpCertificate> spCertificates,

            string? spEntityId)
        {
            CallbackUri = callbackUri;
            SpCertificates = spCertificates;
            SpEntityId = spEntityId;
        }
    }
}
