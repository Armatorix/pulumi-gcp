// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Gcp.Logging.Inputs
{

    public sealed class MetricBucketOptionsGetArgs : Pulumi.ResourceArgs
    {
        [Input("explicitBuckets")]
        public Input<Inputs.MetricBucketOptionsExplicitBucketsGetArgs>? ExplicitBuckets { get; set; }

        [Input("exponentialBuckets")]
        public Input<Inputs.MetricBucketOptionsExponentialBucketsGetArgs>? ExponentialBuckets { get; set; }

        [Input("linearBuckets")]
        public Input<Inputs.MetricBucketOptionsLinearBucketsGetArgs>? LinearBuckets { get; set; }

        public MetricBucketOptionsGetArgs()
        {
        }
    }
}
