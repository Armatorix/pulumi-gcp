// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Gcp.Dns.Outputs
{

    [OutputType]
    public sealed class GetKeysZoneSigningKeyDigestResult
    {
        public readonly string? Digest;
        public readonly string? Type;

        [OutputConstructor]
        private GetKeysZoneSigningKeyDigestResult(
            string? digest,

            string? type)
        {
            Digest = digest;
            Type = type;
        }
    }
}