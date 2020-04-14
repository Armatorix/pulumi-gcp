// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Gcp.Compute.Inputs
{

    public sealed class URLMapPathMatcherArgs : Pulumi.ResourceArgs
    {
        [Input("defaultService")]
        public Input<string>? DefaultService { get; set; }

        [Input("description")]
        public Input<string>? Description { get; set; }

        [Input("headerAction")]
        public Input<Inputs.URLMapPathMatcherHeaderActionArgs>? HeaderAction { get; set; }

        [Input("name", required: true)]
        public Input<string> Name { get; set; } = null!;

        [Input("pathRules")]
        private InputList<Inputs.URLMapPathMatcherPathRuleArgs>? _pathRules;
        public InputList<Inputs.URLMapPathMatcherPathRuleArgs> PathRules
        {
            get => _pathRules ?? (_pathRules = new InputList<Inputs.URLMapPathMatcherPathRuleArgs>());
            set => _pathRules = value;
        }

        [Input("routeRules")]
        private InputList<Inputs.URLMapPathMatcherRouteRuleArgs>? _routeRules;
        public InputList<Inputs.URLMapPathMatcherRouteRuleArgs> RouteRules
        {
            get => _routeRules ?? (_routeRules = new InputList<Inputs.URLMapPathMatcherRouteRuleArgs>());
            set => _routeRules = value;
        }

        public URLMapPathMatcherArgs()
        {
        }
    }
}
