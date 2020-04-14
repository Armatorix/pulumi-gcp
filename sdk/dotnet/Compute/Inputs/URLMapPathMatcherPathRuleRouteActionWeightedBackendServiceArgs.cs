// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Gcp.Compute.Inputs
{

    public sealed class URLMapPathMatcherPathRuleRouteActionWeightedBackendServiceArgs : Pulumi.ResourceArgs
    {
        [Input("backendService", required: true)]
        public Input<string> BackendService { get; set; } = null!;

        [Input("headerAction")]
        public Input<Inputs.URLMapPathMatcherPathRuleRouteActionWeightedBackendServiceHeaderActionArgs>? HeaderAction { get; set; }

        [Input("weight", required: true)]
        public Input<int> Weight { get; set; } = null!;

        public URLMapPathMatcherPathRuleRouteActionWeightedBackendServiceArgs()
        {
        }
    }
}
