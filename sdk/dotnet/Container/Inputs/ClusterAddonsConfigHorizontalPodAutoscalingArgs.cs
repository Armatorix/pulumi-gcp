// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Gcp.Container.Inputs
{

    public sealed class ClusterAddonsConfigHorizontalPodAutoscalingArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The status of the Istio addon, which makes it easy to set up Istio for services in a
        /// cluster. It is disabled by default. Set `disabled = false` to enable.
        /// </summary>
        [Input("disabled", required: true)]
        public Input<bool> Disabled { get; set; } = null!;

        public ClusterAddonsConfigHorizontalPodAutoscalingArgs()
        {
        }
    }
}
