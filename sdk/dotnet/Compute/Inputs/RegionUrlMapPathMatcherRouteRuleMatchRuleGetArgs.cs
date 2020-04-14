// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Gcp.Compute.Inputs
{

    public sealed class RegionUrlMapPathMatcherRouteRuleMatchRuleGetArgs : Pulumi.ResourceArgs
    {
        [Input("fullPathMatch")]
        public Input<string>? FullPathMatch { get; set; }

        [Input("headerMatches")]
        private InputList<Inputs.RegionUrlMapPathMatcherRouteRuleMatchRuleHeaderMatchGetArgs>? _headerMatches;
        public InputList<Inputs.RegionUrlMapPathMatcherRouteRuleMatchRuleHeaderMatchGetArgs> HeaderMatches
        {
            get => _headerMatches ?? (_headerMatches = new InputList<Inputs.RegionUrlMapPathMatcherRouteRuleMatchRuleHeaderMatchGetArgs>());
            set => _headerMatches = value;
        }

        [Input("ignoreCase")]
        public Input<bool>? IgnoreCase { get; set; }

        [Input("metadataFilters")]
        private InputList<Inputs.RegionUrlMapPathMatcherRouteRuleMatchRuleMetadataFilterGetArgs>? _metadataFilters;
        public InputList<Inputs.RegionUrlMapPathMatcherRouteRuleMatchRuleMetadataFilterGetArgs> MetadataFilters
        {
            get => _metadataFilters ?? (_metadataFilters = new InputList<Inputs.RegionUrlMapPathMatcherRouteRuleMatchRuleMetadataFilterGetArgs>());
            set => _metadataFilters = value;
        }

        [Input("prefixMatch")]
        public Input<string>? PrefixMatch { get; set; }

        [Input("queryParameterMatches")]
        private InputList<Inputs.RegionUrlMapPathMatcherRouteRuleMatchRuleQueryParameterMatchGetArgs>? _queryParameterMatches;
        public InputList<Inputs.RegionUrlMapPathMatcherRouteRuleMatchRuleQueryParameterMatchGetArgs> QueryParameterMatches
        {
            get => _queryParameterMatches ?? (_queryParameterMatches = new InputList<Inputs.RegionUrlMapPathMatcherRouteRuleMatchRuleQueryParameterMatchGetArgs>());
            set => _queryParameterMatches = value;
        }

        [Input("regexMatch")]
        public Input<string>? RegexMatch { get; set; }

        public RegionUrlMapPathMatcherRouteRuleMatchRuleGetArgs()
        {
        }
    }
}
