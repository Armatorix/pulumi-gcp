// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Gcp.Compute.Inputs
{

    public sealed class URLMapPathMatcherRouteRuleRouteActionFaultInjectionPolicyDelayGetArgs : Pulumi.ResourceArgs
    {
        [Input("fixedDelay")]
        public Input<Inputs.URLMapPathMatcherRouteRuleRouteActionFaultInjectionPolicyDelayFixedDelayGetArgs>? FixedDelay { get; set; }

        [Input("percentage")]
        public Input<double>? Percentage { get; set; }

        public URLMapPathMatcherRouteRuleRouteActionFaultInjectionPolicyDelayGetArgs()
        {
        }
    }
}
