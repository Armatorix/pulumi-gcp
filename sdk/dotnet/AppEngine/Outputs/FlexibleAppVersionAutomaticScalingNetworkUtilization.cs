// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Gcp.AppEngine.Outputs
{

    [OutputType]
    public sealed class FlexibleAppVersionAutomaticScalingNetworkUtilization
    {
        public readonly int? TargetReceivedBytesPerSecond;
        public readonly int? TargetReceivedPacketsPerSecond;
        public readonly int? TargetSentBytesPerSecond;
        public readonly int? TargetSentPacketsPerSecond;

        [OutputConstructor]
        private FlexibleAppVersionAutomaticScalingNetworkUtilization(
            int? targetReceivedBytesPerSecond,

            int? targetReceivedPacketsPerSecond,

            int? targetSentBytesPerSecond,

            int? targetSentPacketsPerSecond)
        {
            TargetReceivedBytesPerSecond = targetReceivedBytesPerSecond;
            TargetReceivedPacketsPerSecond = targetReceivedPacketsPerSecond;
            TargetSentBytesPerSecond = targetSentBytesPerSecond;
            TargetSentPacketsPerSecond = targetSentPacketsPerSecond;
        }
    }
}
