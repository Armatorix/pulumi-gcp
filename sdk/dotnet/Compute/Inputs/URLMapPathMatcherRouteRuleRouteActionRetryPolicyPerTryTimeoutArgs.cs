// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Gcp.Compute.Inputs
{

    public sealed class URLMapPathMatcherRouteRuleRouteActionRetryPolicyPerTryTimeoutArgs : Pulumi.ResourceArgs
    {
        [Input("nanos")]
        public Input<int>? Nanos { get; set; }

        [Input("seconds", required: true)]
        public Input<string> Seconds { get; set; } = null!;

        public URLMapPathMatcherRouteRuleRouteActionRetryPolicyPerTryTimeoutArgs()
        {
        }
    }
}
