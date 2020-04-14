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
    public sealed class SnapshotSnapshotEncryptionKey
    {
        public readonly string RawKey;
        public readonly string? Sha256;

        [OutputConstructor]
        private SnapshotSnapshotEncryptionKey(
            string rawKey,

            string? sha256)
        {
            RawKey = rawKey;
            Sha256 = sha256;
        }
    }
}
