// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Gcp.Monitoring.Inputs
{

    public sealed class AlertPolicyConditionConditionAbsentTriggerArgs : Pulumi.ResourceArgs
    {
        [Input("count")]
        public Input<int>? Count { get; set; }

        [Input("percent")]
        public Input<double>? Percent { get; set; }

        public AlertPolicyConditionConditionAbsentTriggerArgs()
        {
        }
    }
}
