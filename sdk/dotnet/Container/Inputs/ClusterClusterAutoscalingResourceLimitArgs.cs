// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Gcp.Container.Inputs
{

    public sealed class ClusterClusterAutoscalingResourceLimitArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Maximum amount of the resource in the cluster.
        /// </summary>
        [Input("maximum")]
        public Input<int>? Maximum { get; set; }

        /// <summary>
        /// Minimum amount of the resource in the cluster.
        /// </summary>
        [Input("minimum")]
        public Input<int>? Minimum { get; set; }

        /// <summary>
        /// The type of the resource. For example, `cpu` and
        /// `memory`.  See the [guide to using Node Auto-Provisioning](https://cloud.google.com/kubernetes-engine/docs/how-to/node-auto-provisioning)
        /// for a list of types.
        /// </summary>
        [Input("resourceType", required: true)]
        public Input<string> ResourceType { get; set; } = null!;

        public ClusterClusterAutoscalingResourceLimitArgs()
        {
        }
    }
}