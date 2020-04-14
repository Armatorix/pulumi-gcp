// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Gcp.Compute.Inputs
{

    public sealed class InstanceTemplateGuestAcceleratorGetArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The number of the guest accelerator cards exposed to this instance.
        /// </summary>
        [Input("count", required: true)]
        public Input<int> Count { get; set; } = null!;

        /// <summary>
        /// The accelerator type resource to expose to this instance. E.g. `nvidia-tesla-k80`.
        /// </summary>
        [Input("type", required: true)]
        public Input<string> Type { get; set; } = null!;

        public InstanceTemplateGuestAcceleratorGetArgs()
        {
        }
    }
}
