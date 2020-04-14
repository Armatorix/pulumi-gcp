// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Gcp.Container.Outputs
{

    [OutputType]
    public sealed class NodePoolNodeConfig
    {
        public readonly string? BootDiskKmsKey;
        public readonly int? DiskSizeGb;
        public readonly string? DiskType;
        public readonly ImmutableArray<Outputs.NodePoolNodeConfigGuestAccelerator> GuestAccelerators;
        public readonly string? ImageType;
        public readonly ImmutableDictionary<string, string>? Labels;
        public readonly int? LocalSsdCount;
        public readonly string? MachineType;
        public readonly ImmutableDictionary<string, string>? Metadata;
        public readonly string? MinCpuPlatform;
        public readonly ImmutableArray<string> OauthScopes;
        public readonly bool? Preemptible;
        public readonly Outputs.NodePoolNodeConfigSandboxConfig? SandboxConfig;
        public readonly string? ServiceAccount;
        public readonly Outputs.NodePoolNodeConfigShieldedInstanceConfig? ShieldedInstanceConfig;
        public readonly ImmutableArray<string> Tags;
        public readonly ImmutableArray<Outputs.NodePoolNodeConfigTaint> Taints;
        public readonly Outputs.NodePoolNodeConfigWorkloadMetadataConfig? WorkloadMetadataConfig;

        [OutputConstructor]
        private NodePoolNodeConfig(
            string? bootDiskKmsKey,

            int? diskSizeGb,

            string? diskType,

            ImmutableArray<Outputs.NodePoolNodeConfigGuestAccelerator> guestAccelerators,

            string? imageType,

            ImmutableDictionary<string, string>? labels,

            int? localSsdCount,

            string? machineType,

            ImmutableDictionary<string, string>? metadata,

            string? minCpuPlatform,

            ImmutableArray<string> oauthScopes,

            bool? preemptible,

            Outputs.NodePoolNodeConfigSandboxConfig? sandboxConfig,

            string? serviceAccount,

            Outputs.NodePoolNodeConfigShieldedInstanceConfig? shieldedInstanceConfig,

            ImmutableArray<string> tags,

            ImmutableArray<Outputs.NodePoolNodeConfigTaint> taints,

            Outputs.NodePoolNodeConfigWorkloadMetadataConfig? workloadMetadataConfig)
        {
            BootDiskKmsKey = bootDiskKmsKey;
            DiskSizeGb = diskSizeGb;
            DiskType = diskType;
            GuestAccelerators = guestAccelerators;
            ImageType = imageType;
            Labels = labels;
            LocalSsdCount = localSsdCount;
            MachineType = machineType;
            Metadata = metadata;
            MinCpuPlatform = minCpuPlatform;
            OauthScopes = oauthScopes;
            Preemptible = preemptible;
            SandboxConfig = sandboxConfig;
            ServiceAccount = serviceAccount;
            ShieldedInstanceConfig = shieldedInstanceConfig;
            Tags = tags;
            Taints = taints;
            WorkloadMetadataConfig = workloadMetadataConfig;
        }
    }
}
