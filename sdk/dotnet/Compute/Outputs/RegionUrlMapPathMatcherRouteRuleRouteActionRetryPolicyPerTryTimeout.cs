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
    public sealed class RegionUrlMapPathMatcherRouteRuleRouteActionRetryPolicyPerTryTimeout
    {
        public readonly int? Nanos;
        public readonly string Seconds;

        [OutputConstructor]
        private RegionUrlMapPathMatcherRouteRuleRouteActionRetryPolicyPerTryTimeout(
            int? nanos,

            string seconds)
        {
            Nanos = nanos;
            Seconds = seconds;
        }
    }
}
