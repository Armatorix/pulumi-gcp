// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Gcp.Compute.Inputs
{

    public sealed class URLMapPathMatcherPathRuleRouteActionFaultInjectionPolicyArgs : Pulumi.ResourceArgs
    {
        [Input("abort")]
        public Input<Inputs.URLMapPathMatcherPathRuleRouteActionFaultInjectionPolicyAbortArgs>? Abort { get; set; }

        [Input("delay")]
        public Input<Inputs.URLMapPathMatcherPathRuleRouteActionFaultInjectionPolicyDelayArgs>? Delay { get; set; }

        public URLMapPathMatcherPathRuleRouteActionFaultInjectionPolicyArgs()
        {
        }
    }
}
