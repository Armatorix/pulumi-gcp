// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Gcp.Compute.Inputs
{

    public sealed class GlobalForwardingRuleMetadataFilterGetArgs : Pulumi.ResourceArgs
    {
        [Input("filterLabels", required: true)]
        private InputList<Inputs.GlobalForwardingRuleMetadataFilterFilterLabelGetArgs>? _filterLabels;
        public InputList<Inputs.GlobalForwardingRuleMetadataFilterFilterLabelGetArgs> FilterLabels
        {
            get => _filterLabels ?? (_filterLabels = new InputList<Inputs.GlobalForwardingRuleMetadataFilterFilterLabelGetArgs>());
            set => _filterLabels = value;
        }

        [Input("filterMatchCriteria", required: true)]
        public Input<string> FilterMatchCriteria { get; set; } = null!;

        public GlobalForwardingRuleMetadataFilterGetArgs()
        {
        }
    }
}
