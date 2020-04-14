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
    public sealed class FlexibleAppVersionAutomaticScalingCpuUtilization
    {
        public readonly string? AggregationWindowLength;
        public readonly double TargetUtilization;

        [OutputConstructor]
        private FlexibleAppVersionAutomaticScalingCpuUtilization(
            string? aggregationWindowLength,

            double targetUtilization)
        {
            AggregationWindowLength = aggregationWindowLength;
            TargetUtilization = targetUtilization;
        }
    }
}
