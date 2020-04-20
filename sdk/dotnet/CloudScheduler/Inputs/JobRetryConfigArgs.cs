// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Gcp.CloudScheduler.Inputs
{

    public sealed class JobRetryConfigArgs : Pulumi.ResourceArgs
    {
        [Input("maxBackoffDuration")]
        public Input<string>? MaxBackoffDuration { get; set; }

        [Input("maxDoublings")]
        public Input<int>? MaxDoublings { get; set; }

        [Input("maxRetryDuration")]
        public Input<string>? MaxRetryDuration { get; set; }

        [Input("minBackoffDuration")]
        public Input<string>? MinBackoffDuration { get; set; }

        [Input("retryCount")]
        public Input<int>? RetryCount { get; set; }

        public JobRetryConfigArgs()
        {
        }
    }
}