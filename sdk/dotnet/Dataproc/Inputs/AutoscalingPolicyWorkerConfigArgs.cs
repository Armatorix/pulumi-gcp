// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Gcp.Dataproc.Inputs
{

    public sealed class AutoscalingPolicyWorkerConfigArgs : Pulumi.ResourceArgs
    {
        [Input("maxInstances", required: true)]
        public Input<int> MaxInstances { get; set; } = null!;

        [Input("minInstances")]
        public Input<int>? MinInstances { get; set; }

        [Input("weight")]
        public Input<int>? Weight { get; set; }

        public AutoscalingPolicyWorkerConfigArgs()
        {
        }
    }
}
