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
    public sealed class PacketMirroringMirroredResources
    {
        public readonly ImmutableArray<Outputs.PacketMirroringMirroredResourcesInstance> Instances;
        public readonly ImmutableArray<Outputs.PacketMirroringMirroredResourcesSubnetwork> Subnetworks;
        public readonly ImmutableArray<string> Tags;

        [OutputConstructor]
        private PacketMirroringMirroredResources(
            ImmutableArray<Outputs.PacketMirroringMirroredResourcesInstance> instances,

            ImmutableArray<Outputs.PacketMirroringMirroredResourcesSubnetwork> subnetworks,

            ImmutableArray<string> tags)
        {
            Instances = instances;
            Subnetworks = subnetworks;
            Tags = tags;
        }
    }
}
