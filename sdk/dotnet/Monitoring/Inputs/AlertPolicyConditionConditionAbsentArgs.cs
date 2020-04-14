// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Gcp.Monitoring.Inputs
{

    public sealed class AlertPolicyConditionConditionAbsentArgs : Pulumi.ResourceArgs
    {
        [Input("aggregations")]
        private InputList<Inputs.AlertPolicyConditionConditionAbsentAggregationArgs>? _aggregations;
        public InputList<Inputs.AlertPolicyConditionConditionAbsentAggregationArgs> Aggregations
        {
            get => _aggregations ?? (_aggregations = new InputList<Inputs.AlertPolicyConditionConditionAbsentAggregationArgs>());
            set => _aggregations = value;
        }

        [Input("duration", required: true)]
        public Input<string> Duration { get; set; } = null!;

        [Input("filter")]
        public Input<string>? Filter { get; set; }

        [Input("trigger")]
        public Input<Inputs.AlertPolicyConditionConditionAbsentTriggerArgs>? Trigger { get; set; }

        public AlertPolicyConditionConditionAbsentArgs()
        {
        }
    }
}
