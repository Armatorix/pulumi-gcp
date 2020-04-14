// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Gcp.PubSub.Inputs
{

    public sealed class SubscriptionDeadLetterPolicyArgs : Pulumi.ResourceArgs
    {
        [Input("deadLetterTopic")]
        public Input<string>? DeadLetterTopic { get; set; }

        [Input("maxDeliveryAttempts")]
        public Input<int>? MaxDeliveryAttempts { get; set; }

        public SubscriptionDeadLetterPolicyArgs()
        {
        }
    }
}
