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
    public sealed class FlexibleAppVersionAutomaticScalingRequestUtilization
    {
        public readonly double? TargetConcurrentRequests;
        public readonly string? TargetRequestCountPerSecond;

        [OutputConstructor]
        private FlexibleAppVersionAutomaticScalingRequestUtilization(
            double? targetConcurrentRequests,

            string? targetRequestCountPerSecond)
        {
            TargetConcurrentRequests = targetConcurrentRequests;
            TargetRequestCountPerSecond = targetRequestCountPerSecond;
        }
    }
}
