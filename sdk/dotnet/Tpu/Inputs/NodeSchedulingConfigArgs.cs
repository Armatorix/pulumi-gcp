// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Gcp.Tpu.Inputs
{

    public sealed class NodeSchedulingConfigArgs : Pulumi.ResourceArgs
    {
        [Input("preemptible", required: true)]
        public Input<bool> Preemptible { get; set; } = null!;

        public NodeSchedulingConfigArgs()
        {
        }
    }
}
