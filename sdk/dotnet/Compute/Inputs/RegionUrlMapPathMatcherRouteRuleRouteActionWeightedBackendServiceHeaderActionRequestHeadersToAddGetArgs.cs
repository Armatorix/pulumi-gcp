// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Gcp.Compute.Inputs
{

    public sealed class RegionUrlMapPathMatcherRouteRuleRouteActionWeightedBackendServiceHeaderActionRequestHeadersToAddGetArgs : Pulumi.ResourceArgs
    {
        [Input("headerName", required: true)]
        public Input<string> HeaderName { get; set; } = null!;

        [Input("headerValue", required: true)]
        public Input<string> HeaderValue { get; set; } = null!;

        [Input("replace", required: true)]
        public Input<bool> Replace { get; set; } = null!;

        public RegionUrlMapPathMatcherRouteRuleRouteActionWeightedBackendServiceHeaderActionRequestHeadersToAddGetArgs()
        {
        }
    }
}
