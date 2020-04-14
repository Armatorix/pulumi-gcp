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
    public sealed class ClusterNodePoolUpgradeSettings
    {
        public readonly int MaxSurge;
        public readonly int MaxUnavailable;

        [OutputConstructor]
        private ClusterNodePoolUpgradeSettings(
            int maxSurge,

            int maxUnavailable)
        {
            MaxSurge = maxSurge;
            MaxUnavailable = maxUnavailable;
        }
    }
}
