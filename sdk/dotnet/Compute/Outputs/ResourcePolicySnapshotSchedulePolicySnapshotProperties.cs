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
    public sealed class ResourcePolicySnapshotSchedulePolicySnapshotProperties
    {
        /// <summary>
        /// Whether to perform a 'guest aware' snapshot.
        /// </summary>
        public readonly bool? GuestFlush;
        /// <summary>
        /// A set of key-value pairs.
        /// </summary>
        public readonly ImmutableDictionary<string, string>? Labels;
        /// <summary>
        /// Cloud Storage bucket location to store the auto snapshot
        /// (regional or multi-regional)
        /// </summary>
        public readonly string? StorageLocations;

        [OutputConstructor]
        private ResourcePolicySnapshotSchedulePolicySnapshotProperties(
            bool? guestFlush,

            ImmutableDictionary<string, string>? labels,

            string? storageLocations)
        {
            GuestFlush = guestFlush;
            Labels = labels;
            StorageLocations = storageLocations;
        }
    }
}
